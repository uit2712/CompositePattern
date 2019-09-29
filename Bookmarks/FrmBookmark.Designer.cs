namespace Bookmarks
{
    partial class FrmBookmark
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBookmark));
            this.imglBookmark = new System.Windows.Forms.ImageList(this.components);
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.btnAddPage = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.pnlBookmarkTree = new System.Windows.Forms.Panel();
            this.tvBookmark = new System.Windows.Forms.TreeView();
            this.pnlBookmarkTree.SuspendLayout();
            this.SuspendLayout();
            // 
            // imglBookmark
            // 
            this.imglBookmark.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglBookmark.ImageStream")));
            this.imglBookmark.TransparentColor = System.Drawing.Color.Transparent;
            this.imglBookmark.Images.SetKeyName(0, "closed-folder.png");
            this.imglBookmark.Images.SetKeyName(1, "opened-folder.png");
            this.imglBookmark.Images.SetKeyName(2, "page.png");
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.AutoSize = true;
            this.btnAddFolder.Location = new System.Drawing.Point(830, 12);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(171, 30);
            this.btnAddFolder.TabIndex = 1;
            this.btnAddFolder.Text = "Thêm thư mục";
            this.btnAddFolder.UseVisualStyleBackColor = true;
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // btnAddPage
            // 
            this.btnAddPage.AutoSize = true;
            this.btnAddPage.Location = new System.Drawing.Point(830, 48);
            this.btnAddPage.Name = "btnAddPage";
            this.btnAddPage.Size = new System.Drawing.Size(171, 30);
            this.btnAddPage.TabIndex = 1;
            this.btnAddPage.Text = "Thêm trang";
            this.btnAddPage.UseVisualStyleBackColor = true;
            this.btnAddPage.Click += new System.EventHandler(this.btnAddPage_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.AutoSize = true;
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(830, 84);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(171, 30);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // pnlBookmarkTree
            // 
            this.pnlBookmarkTree.AutoScroll = true;
            this.pnlBookmarkTree.Controls.Add(this.tvBookmark);
            this.pnlBookmarkTree.Location = new System.Drawing.Point(12, 12);
            this.pnlBookmarkTree.Name = "pnlBookmarkTree";
            this.pnlBookmarkTree.Size = new System.Drawing.Size(812, 407);
            this.pnlBookmarkTree.TabIndex = 2;
            // 
            // tvBookmark
            // 
            this.tvBookmark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvBookmark.ImageIndex = 0;
            this.tvBookmark.ImageList = this.imglBookmark;
            this.tvBookmark.Location = new System.Drawing.Point(0, 0);
            this.tvBookmark.Name = "tvBookmark";
            this.tvBookmark.SelectedImageIndex = 0;
            this.tvBookmark.Size = new System.Drawing.Size(812, 407);
            this.tvBookmark.TabIndex = 0;
            this.tvBookmark.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tvBookmark_MouseDown);
            // 
            // FrmBookmark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 431);
            this.Controls.Add(this.pnlBookmarkTree);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddPage);
            this.Controls.Add(this.btnAddFolder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmBookmark";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bookmark";
            this.pnlBookmarkTree.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imglBookmark;
        private System.Windows.Forms.Button btnAddFolder;
        private System.Windows.Forms.Button btnAddPage;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Panel pnlBookmarkTree;
        private System.Windows.Forms.TreeView tvBookmark;
    }
}

