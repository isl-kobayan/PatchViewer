namespace FilterVizChecker
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.folder1 = new System.Windows.Forms.TextBox();
            this.folder2 = new System.Windows.Forms.TextBox();
            this.filterIndex = new System.Windows.Forms.NumericUpDown();
            this.layerList = new System.Windows.Forms.ListBox();
            this.sizeOfImages = new System.Windows.Forms.NumericUpDown();
            this.GoButton = new System.Windows.Forms.Button();
            this.activatedImageBox1 = new System.Windows.Forms.PictureBox();
            this.activatedImageBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.filterIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeOfImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activatedImageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activatedImageBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // folder1
            // 
            this.folder1.AllowDrop = true;
            this.folder1.Location = new System.Drawing.Point(12, 13);
            this.folder1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.folder1.Name = "folder1";
            this.folder1.Size = new System.Drawing.Size(425, 23);
            this.folder1.TabIndex = 0;
            this.folder1.DragDrop += new System.Windows.Forms.DragEventHandler(this.folder1_DragDrop);
            this.folder1.DragEnter += new System.Windows.Forms.DragEventHandler(this.folder1_DragEnter);
            // 
            // folder2
            // 
            this.folder2.AllowDrop = true;
            this.folder2.Location = new System.Drawing.Point(12, 44);
            this.folder2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.folder2.Name = "folder2";
            this.folder2.Size = new System.Drawing.Size(425, 23);
            this.folder2.TabIndex = 1;
            this.folder2.DragDrop += new System.Windows.Forms.DragEventHandler(this.folder2_DragDrop);
            this.folder2.DragEnter += new System.Windows.Forms.DragEventHandler(this.folder2_DragEnter);
            // 
            // filterIndex
            // 
            this.filterIndex.Location = new System.Drawing.Point(721, 13);
            this.filterIndex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filterIndex.Name = "filterIndex";
            this.filterIndex.Size = new System.Drawing.Size(63, 23);
            this.filterIndex.TabIndex = 2;
            this.filterIndex.ValueChanged += new System.EventHandler(this.filterIndex_ValueChanged);
            // 
            // layerList
            // 
            this.layerList.FormattingEnabled = true;
            this.layerList.ItemHeight = 15;
            this.layerList.Location = new System.Drawing.Point(443, 13);
            this.layerList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layerList.Name = "layerList";
            this.layerList.Size = new System.Drawing.Size(178, 109);
            this.layerList.TabIndex = 3;
            this.layerList.SelectedIndexChanged += new System.EventHandler(this.layerList_SelectedIndexChanged);
            // 
            // sizeOfImages
            // 
            this.sizeOfImages.Location = new System.Drawing.Point(721, 44);
            this.sizeOfImages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sizeOfImages.Name = "sizeOfImages";
            this.sizeOfImages.Size = new System.Drawing.Size(47, 23);
            this.sizeOfImages.TabIndex = 4;
            this.sizeOfImages.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(362, 74);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(75, 23);
            this.GoButton.TabIndex = 5;
            this.GoButton.Text = "Go";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // activatedImageBox1
            // 
            this.activatedImageBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.activatedImageBox1.Location = new System.Drawing.Point(12, 129);
            this.activatedImageBox1.Name = "activatedImageBox1";
            this.activatedImageBox1.Size = new System.Drawing.Size(875, 190);
            this.activatedImageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.activatedImageBox1.TabIndex = 7;
            this.activatedImageBox1.TabStop = false;
            // 
            // activatedImageBox2
            // 
            this.activatedImageBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.activatedImageBox2.Location = new System.Drawing.Point(12, 333);
            this.activatedImageBox2.Name = "activatedImageBox2";
            this.activatedImageBox2.Size = new System.Drawing.Size(875, 190);
            this.activatedImageBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.activatedImageBox2.TabIndex = 8;
            this.activatedImageBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(624, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "filter index";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(624, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "images per filter";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 535);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.activatedImageBox2);
            this.Controls.Add(this.activatedImageBox1);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.sizeOfImages);
            this.Controls.Add(this.layerList);
            this.Controls.Add(this.filterIndex);
            this.Controls.Add(this.folder2);
            this.Controls.Add(this.folder1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "PatchViewer";
            ((System.ComponentModel.ISupportInitialize)(this.filterIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeOfImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activatedImageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activatedImageBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox folder1;
        private System.Windows.Forms.TextBox folder2;
        private System.Windows.Forms.NumericUpDown filterIndex;
        private System.Windows.Forms.ListBox layerList;
        private System.Windows.Forms.NumericUpDown sizeOfImages;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.PictureBox activatedImageBox1;
        private System.Windows.Forms.PictureBox activatedImageBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

