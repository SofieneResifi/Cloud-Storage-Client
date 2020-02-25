namespace Cloud_Storage_service
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.listView1 = new System.Windows.Forms.ListView();
            this.NAme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileMenu = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.Past = new System.Windows.Forms.ToolStripMenuItem();
            this.Rename = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.Download = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.percentage = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.jImageButton1 = new JImageButton.JImageButton();
            this.jImageButton2 = new JImageButton.JImageButton();
            this.back = new JImageButton.JImageButton();
            this.upload = new JImageButton.JImageButton();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.dir = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gunaLinePanel2 = new Guna.UI.WinForms.GunaLinePanel();
            this.creationDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.size = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totalSize = new System.Windows.Forms.Label();
            this.newFolder = new JImageButton.JImageButton();
            this.signOut = new JImageButton.JImageButton();
            this.fileMenu.SuspendLayout();
            this.gunaLinePanel1.SuspendLayout();
            this.gunaLinePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.listView1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listView1.BackgroundImage")));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NAme});
            this.listView1.ContextMenuStrip = this.fileMenu;
            this.listView1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.listView1.LabelWrap = false;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(314, 124);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(738, 545);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // NAme
            // 
            this.NAme.Text = "name";
            this.NAme.Width = 200;
            // 
            // fileMenu
            // 
            this.fileMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fileMenu.Depth = 0;
            this.fileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Copy,
            this.Cut,
            this.Past,
            this.Rename,
            this.Delete,
            this.Download});
            this.fileMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.ShowCheckMargin = true;
            this.fileMenu.Size = new System.Drawing.Size(169, 136);
            // 
            // Copy
            // 
            this.Copy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Copy.BackgroundImage")));
            this.Copy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Copy.Image = ((System.Drawing.Image)(resources.GetObject("Copy.Image")));
            this.Copy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(168, 22);
            this.Copy.Text = "      Copy";
            this.Copy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Cut
            // 
            this.Cut.Image = ((System.Drawing.Image)(resources.GetObject("Cut.Image")));
            this.Cut.Name = "Cut";
            this.Cut.Size = new System.Drawing.Size(168, 22);
            this.Cut.Text = "      Cut";
            this.Cut.Click += new System.EventHandler(this.Cut_Click);
            // 
            // Past
            // 
            this.Past.Image = ((System.Drawing.Image)(resources.GetObject("Past.Image")));
            this.Past.Name = "Past";
            this.Past.Size = new System.Drawing.Size(168, 22);
            this.Past.Text = "      Past";
            this.Past.Click += new System.EventHandler(this.Past_Click);
            // 
            // Rename
            // 
            this.Rename.Image = ((System.Drawing.Image)(resources.GetObject("Rename.Image")));
            this.Rename.Name = "Rename";
            this.Rename.Size = new System.Drawing.Size(168, 22);
            this.Rename.Text = "      Rename";
            this.Rename.Click += new System.EventHandler(this.Rename_Click);
            // 
            // Delete
            // 
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(168, 22);
            this.Delete.Text = "      Delete";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Download
            // 
            this.Download.Image = ((System.Drawing.Image)(resources.GetObject("Download.Image")));
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(168, 22);
            this.Download.Text = "      Download";
            this.Download.Click += new System.EventHandler(this.Download_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "file_icon.png");
            this.imageList1.Images.SetKeyName(1, "folder_icon.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(20, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome";
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.BackColor = System.Drawing.Color.Transparent;
            this.user.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.Color.SteelBlue;
            this.user.Location = new System.Drawing.Point(125, 62);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(108, 25);
            this.user.TabIndex = 4;
            this.user.Text = "Welcome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(21, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Storage usage :";
            // 
            // percentage
            // 
            this.percentage.Animated = true;
            this.percentage.AnimationSpeed = 0.4F;
            this.percentage.BackColor = System.Drawing.Color.Transparent;
            this.percentage.BaseColor = System.Drawing.Color.Transparent;
            this.percentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentage.IdleColor = System.Drawing.Color.Gainsboro;
            this.percentage.IdleOffset = 20;
            this.percentage.Image = null;
            this.percentage.ImageSize = new System.Drawing.Size(52, 52);
            this.percentage.Location = new System.Drawing.Point(48, 170);
            this.percentage.Name = "percentage";
            this.percentage.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.percentage.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.percentage.ProgressOffset = 20;
            this.percentage.ProgressThickness = 25;
            this.percentage.Size = new System.Drawing.Size(209, 206);
            this.percentage.TabIndex = 6;
            this.percentage.UseProgressPercentText = true;
            this.percentage.Value = 30;
            // 
            // jImageButton1
            // 
            this.jImageButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.jImageButton1.BackColor = System.Drawing.SystemColors.Highlight;
            this.jImageButton1.CausesValidation = false;
            this.jImageButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.jImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("jImageButton1.ErrorImage")));
            this.jImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("jImageButton1.Image")));
            this.jImageButton1.ImageHover = null;
            this.jImageButton1.InitialImage = null;
            this.jImageButton1.Location = new System.Drawing.Point(-23, -46);
            this.jImageButton1.Name = "jImageButton1";
            this.jImageButton1.Size = new System.Drawing.Size(157, 47);
            this.jImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.jImageButton1.TabIndex = 7;
            this.jImageButton1.Zoom = 4;
            // 
            // jImageButton2
            // 
            this.jImageButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.jImageButton2.BackColor = System.Drawing.SystemColors.Highlight;
            this.jImageButton2.CausesValidation = false;
            this.jImageButton2.Cursor = System.Windows.Forms.Cursors.Default;
            this.jImageButton2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("jImageButton2.ErrorImage")));
            this.jImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("jImageButton2.Image")));
            this.jImageButton2.ImageHover = null;
            this.jImageButton2.InitialImage = null;
            this.jImageButton2.Location = new System.Drawing.Point(-23, -46);
            this.jImageButton2.Name = "jImageButton2";
            this.jImageButton2.Size = new System.Drawing.Size(157, 47);
            this.jImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.jImageButton2.TabIndex = 8;
            this.jImageButton2.Zoom = 4;
            // 
            // back
            // 
            this.back.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.back.BackColor = System.Drawing.SystemColors.Highlight;
            this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.CausesValidation = false;
            this.back.Cursor = System.Windows.Forms.Cursors.Default;
            this.back.ErrorImage = ((System.Drawing.Image)(resources.GetObject("back.ErrorImage")));
            this.back.Image = null;
            this.back.ImageHover = null;
            this.back.InitialImage = null;
            this.back.Location = new System.Drawing.Point(900, 566);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(141, 60);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.back.TabIndex = 9;
            this.back.Zoom = 4;
            this.back.Click += new System.EventHandler(this.Back_Click);
            // 
            // upload
            // 
            this.upload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.upload.BackColor = System.Drawing.SystemColors.Highlight;
            this.upload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("upload.BackgroundImage")));
            this.upload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.upload.CausesValidation = false;
            this.upload.Cursor = System.Windows.Forms.Cursors.Default;
            this.upload.ErrorImage = ((System.Drawing.Image)(resources.GetObject("upload.ErrorImage")));
            this.upload.Image = null;
            this.upload.ImageHover = null;
            this.upload.InitialImage = null;
            this.upload.Location = new System.Drawing.Point(753, 569);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(141, 60);
            this.upload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.upload.TabIndex = 10;
            this.upload.Zoom = 4;
            this.upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.gunaLinePanel1.Controls.Add(this.dir);
            this.gunaLinePanel1.Controls.Add(this.label4);
            this.gunaLinePanel1.Controls.Add(this.label3);
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Black;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(459, 632);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(582, 27);
            this.gunaLinePanel1.TabIndex = 11;
            // 
            // dir
            // 
            this.dir.AutoSize = true;
            this.dir.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dir.Location = new System.Drawing.Point(94, 0);
            this.dir.Name = "dir";
            this.dir.Size = new System.Drawing.Size(49, 20);
            this.dir.TabIndex = 4;
            this.dir.Text = "54151";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Actual path :";
            // 
            // gunaLinePanel2
            // 
            this.gunaLinePanel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.gunaLinePanel2.Controls.Add(this.creationDate);
            this.gunaLinePanel2.Controls.Add(this.label8);
            this.gunaLinePanel2.Controls.Add(this.size);
            this.gunaLinePanel2.Controls.Add(this.label6);
            this.gunaLinePanel2.LineColor = System.Drawing.Color.Black;
            this.gunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel2.Location = new System.Drawing.Point(327, 571);
            this.gunaLinePanel2.Name = "gunaLinePanel2";
            this.gunaLinePanel2.Size = new System.Drawing.Size(117, 88);
            this.gunaLinePanel2.TabIndex = 12;
            // 
            // creationDate
            // 
            this.creationDate.AutoSize = true;
            this.creationDate.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creationDate.Location = new System.Drawing.Point(3, 60);
            this.creationDate.Name = "creationDate";
            this.creationDate.Size = new System.Drawing.Size(49, 20);
            this.creationDate.TabIndex = 3;
            this.creationDate.Text = "54151";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Creation date :";
            // 
            // size
            // 
            this.size.AutoSize = true;
            this.size.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size.Location = new System.Drawing.Point(3, 20);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(65, 20);
            this.size.TabIndex = 1;
            this.size.Text = "5154151";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "item size :";
            // 
            // totalSize
            // 
            this.totalSize.AutoSize = true;
            this.totalSize.BackColor = System.Drawing.Color.Transparent;
            this.totalSize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSize.ForeColor = System.Drawing.Color.Black;
            this.totalSize.Location = new System.Drawing.Point(155, 124);
            this.totalSize.Name = "totalSize";
            this.totalSize.Size = new System.Drawing.Size(47, 19);
            this.totalSize.TabIndex = 14;
            this.totalSize.Text = "/1GB";
            // 
            // newFolder
            // 
            this.newFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.newFolder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newFolder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newFolder.BackgroundImage")));
            this.newFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newFolder.CausesValidation = false;
            this.newFolder.Cursor = System.Windows.Forms.Cursors.Default;
            this.newFolder.ErrorImage = ((System.Drawing.Image)(resources.GetObject("newFolder.ErrorImage")));
            this.newFolder.Image = null;
            this.newFolder.ImageHover = null;
            this.newFolder.InitialImage = null;
            this.newFolder.Location = new System.Drawing.Point(606, 569);
            this.newFolder.Name = "newFolder";
            this.newFolder.Size = new System.Drawing.Size(141, 57);
            this.newFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.newFolder.TabIndex = 15;
            this.newFolder.Zoom = 4;
            this.newFolder.Click += new System.EventHandler(this.NewFolder_Click);
            // 
            // signOut
            // 
            this.signOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.signOut.BackColor = System.Drawing.SystemColors.Highlight;
            this.signOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signOut.BackgroundImage")));
            this.signOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.signOut.CausesValidation = false;
            this.signOut.Cursor = System.Windows.Forms.Cursors.Default;
            this.signOut.ErrorImage = ((System.Drawing.Image)(resources.GetObject("signOut.ErrorImage")));
            this.signOut.Image = null;
            this.signOut.ImageHover = null;
            this.signOut.InitialImage = null;
            this.signOut.Location = new System.Drawing.Point(459, 569);
            this.signOut.Name = "signOut";
            this.signOut.Size = new System.Drawing.Size(141, 57);
            this.signOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.signOut.TabIndex = 16;
            this.signOut.Zoom = 4;
            this.signOut.Click += new System.EventHandler(this.SignOut_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.newFolder);
            this.Controls.Add(this.signOut);
            this.Controls.Add(this.totalSize);
            this.Controls.Add(this.back);
            this.Controls.Add(this.gunaLinePanel2);
            this.Controls.Add(this.gunaLinePanel1);
            this.Controls.Add(this.upload);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.jImageButton2);
            this.Controls.Add(this.jImageButton1);
            this.Controls.Add(this.percentage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.user);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1080, 720);
            this.MinimumSize = new System.Drawing.Size(1080, 720);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Storage  Service :";
            this.Load += new System.EventHandler(this.Main_Load);
            this.fileMenu.ResumeLayout(false);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.gunaLinePanel2.ResumeLayout(false);
            this.gunaLinePanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader NAme;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialContextMenuStrip fileMenu;
        private System.Windows.Forms.ToolStripMenuItem Copy;
        private System.Windows.Forms.ToolStripMenuItem Cut;
        private System.Windows.Forms.ToolStripMenuItem Past;
        private System.Windows.Forms.ToolStripMenuItem Rename;
        private System.Windows.Forms.ToolStripMenuItem Delete;
        private System.Windows.Forms.ToolStripMenuItem Download;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private JImageButton.JImageButton jImageButton1;
        private JImageButton.JImageButton jImageButton2;
        private JImageButton.JImageButton back;
        private JImageButton.JImageButton upload;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel2;
        private System.Windows.Forms.Label creationDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label size;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label user;
        private System.Windows.Forms.Label dir;
        private JImageButton.JImageButton newFolder;
        private JImageButton.JImageButton signOut;
        public Guna.UI.WinForms.GunaCircleProgressBar percentage;
        public System.Windows.Forms.Label totalSize;
    }
}