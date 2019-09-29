using System;
using System.Windows.Forms;

namespace Bookmarks
{
    public partial class FrmAddFolder : Form
    {
        public FrmAddFolder()
        {
            InitializeComponent();
        }

        private FrmBookmark _frmBookmark = null;

        public FrmAddFolder SetFormBookmark(FrmBookmark frmBookmark)
        {
            _frmBookmark = frmBookmark;
            return this;
        }

        private void txtFolderName_TextChanged(object sender, EventArgs e)
        {
            btnAddFolder.Enabled = !("".Equals(txtFolderName.Text.Trim()));
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            _frmBookmark?.AddFolder(txtFolderName.Text.Trim());
            Close();
        }
    }
}
