using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;

namespace FilterVizChecker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        
        private void folder1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // ドラッグ中のファイルやディレクトリの取得
                string[] drags = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string folder in drags)
                {
                    if (Directory.Exists(folder))
                    {
                        e.Effect = DragDropEffects.Copy;
                        break;
                    }
                }
            }
        }
        
        private void folder1_DragDrop(object sender, DragEventArgs e)
        {
            // ドラッグ＆ドロップされたディレクトリ
            string[] folders = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string folder in folders)
            {
                if (Directory.Exists(folder))
                {
                    folder1.Text = folder;
                }
            }
        }

        private void folder2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // ドラッグ中のファイルやディレクトリの取得
                string[] drags = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string folder in drags)
                {
                    if (Directory.Exists(folder))
                    {
                        e.Effect = DragDropEffects.Copy;
                        break;
                    }
                }
            }
        }

        private void folder2_DragDrop(object sender, DragEventArgs e)
        {
            // ドラッグ＆ドロップされたディレクトリ
            string[] folders = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string folder in folders)
            {
                if (Directory.Exists(folder))
                {
                    folder2.Text = folder;
                }
            }
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            layerList.Items.Clear();

            string[] layers1 = Directory.GetDirectories(folder1.Text, "*", SearchOption.TopDirectoryOnly).Select(l => Path.GetFileName(l)).ToArray();
            string[] layers2 = Directory.GetDirectories(folder2.Text, "*", SearchOption.TopDirectoryOnly).Select(l => Path.GetFileName(l)).ToArray();

            string[] layers = layers1.Intersect(layers2).ToArray();

            //string[] layers = Directory.GetDirectories(folder1.Text, "*", SearchOption.TopDirectoryOnly);
            foreach (string layer in layers)
            {
                layerList.Items.Add(Path.GetFileName(layer));
            }


            layerList.SelectedIndex = 0;
            //MessageBox.Show(layerList.SelectedItem.ToString());
            UpdateImage();
            //Cv2.NamedWindow("a", WindowMode.AutoSize | WindowMode.KeepRatio);
            //Cv2.ImShow("a", GetActivatedImages(folder1.Text, layerList.SelectedItem.ToString(), 0, 10));
        }

        private Mat GetActivatedImages(string path, string layer, int index, int size)
        {
            Mat[] images = new Mat[size];
            Mat allImage;
            int sumwidth = 0;
            int maxheight = 0;
            for(int i=0; i<size; i++)
            {
                string filename = path + Path.DirectorySeparatorChar + layer + Path.DirectorySeparatorChar
                    + index.ToString("0000") + "_" + i.ToString("00") + ".png";
                images[i] = new Mat(filename);
                sumwidth += images[i].Cols;
                if (maxheight < images[i].Rows) maxheight = images[i].Rows;
                //Cv2.NamedWindow("b" + i);
                //Cv2.ImShow("b" + i, images[i]);
            }
            allImage = new Mat(maxheight, sumwidth, MatType.CV_8UC3);
            int x = 0;
            for(int i = 0; i<size; i++)
            {
                allImage[0, images[i].Rows, x, x + images[i].Cols] = images[i];
                x += images[i].Cols;
            }
            return allImage;
        }

        private void UpdateImage()
        {
            Mat image1 = GetActivatedImages(folder1.Text, layerList.SelectedItem.ToString(),
                (int)filterIndex.Value, (int)sizeOfImages.Value);
            var bitmap1 = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(image1);
            activatedImageBox1.Image = bitmap1;

            Mat image2 = GetActivatedImages(folder2.Text, layerList.SelectedItem.ToString(),
                (int)filterIndex.Value, (int)sizeOfImages.Value);
            var bitmap2 = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(image2);
            activatedImageBox2.Image = bitmap2;
        }

        private void filterIndex_ValueChanged(object sender, EventArgs e)
        {
            //Cv2.NamedWindow("a", WindowMode.AutoSize | WindowMode.KeepRatio);
            //Cv2.ImShow("a", GetActivatedImages(folder1.Text, layerList.SelectedItem.ToString(),
            //    (int)filterIndex.Value, (int)sizeOfImages.Value));
            UpdateImage();
        }

        private void layerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterIndex.Value = 0;
            //string[] filters = Directory.GetFiles(folder1.Text + Path.DirectorySeparatorChar
            //    + layerList.SelectedItem.ToString(), "*_00.png", SearchOption.TopDirectoryOnly);
            //filterIndex.Maximum = filters.Length - 1;
            int nOfFilters = Directory.GetFiles(folder1.Text + Path.DirectorySeparatorChar
                + layerList.SelectedItem.ToString(), "*_00.png", SearchOption.TopDirectoryOnly).Count();
            filterIndex.Maximum = nOfFilters;

            int imagesPerFilter = Directory.GetFiles(folder1.Text + Path.DirectorySeparatorChar
                + layerList.SelectedItem.ToString(), "0000_*.png", SearchOption.TopDirectoryOnly).Count();
            sizeOfImages.Maximum = imagesPerFilter;

            UpdateImage();
        }
    }
}
