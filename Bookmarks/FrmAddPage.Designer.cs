namespace Bookmarks
{
    partial class FrmAddPage
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
            this.btnAddPage = new System.Windows.Forms.Button();
            this.txtPageName = new System.Windows.Forms.TextBox();
            this.lblPageName = new System.Windows.Forms.Label();
            this.lblLink = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddPage
            // 
            this.btnAddPage.AutoSize = true;
            this.btnAddPage.Enabled = false;
            this.btnAddPage.Location = new System.Drawing.Point(12, 77);
            this.btnAddPage.Name = "btnAddPage";
            this.btnAddPage.Size = new System.Drawing.Size(326, 30);
            this.btnAddPage.TabIndex = 2;
            this.btnAddPage.Text = "Thêm trang";
            this.btnAddPage.UseVisualStyleBackColor = true;
            this.btnAddPage.Click += new System.EventHandler(this.btnAddPage_Click);
            // 
            // txtPageName
            // 
            this.txtPageName.Location = new System.Drawing.Point(90, 11);
            this.txtPageName.Name = "txtPageName";
            this.txtPageName.Size = new System.Drawing.Size(248, 26);
            this.txtPageName.TabIndex = 0;
            this.txtPageName.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // lblPageName
            // 
            this.lblPageName.AutoSize = true;
            this.lblPageName.Location = new System.Drawing.Point(12, 14);
            this.lblPageName.Name = "lblPageName";
            this.lblPageName.Size = new System.Drawing.Size(36, 20);
            this.lblPageName.TabIndex = 3;
            this.lblPageName.Text = "Tên";
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(12, 46);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(65, 20);
            this.lblLink.TabIndex = 3;
            this.lblLink.Text = "Liên kết";
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(90, 43);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(248, 26);
            this.txtLink.TabIndex = 1;
            this.txtLink.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // FrmAddPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 118);
            this.Controls.Add(this.btnAddPage);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.txtPageName);
            this.Controls.Add(this.lblPageName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAddPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm trang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddPage;
        private System.Windows.Forms.TextBox txtPageName;
        private System.Windows.Forms.Label lblPageName;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.TextBox txtLink;
    }
}