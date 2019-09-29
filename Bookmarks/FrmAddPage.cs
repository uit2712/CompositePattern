using System;
using System.Windows.Forms;

namespace Bookmarks
{
    public partial class FrmAddPage : Form
    {
        public FrmAddPage()
        {
            InitializeComponent();
        }

        private FrmBookmark _frmBookmark = null;

        public FrmAddPage SetFormBookmark(FrmBookmark frmBookmark)
        {
            _frmBookmark = frmBookmark;
            return this;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            btnAddPage.Enabled = !("".Equals(txtLink.Text.Trim()) || "".Equals(txtPageName.Text.Trim()));
        }

        private void btnAddPage_Click(object sender, EventArgs e)
        {
            _frmBookmark?.AddPage(txtPageName.Text.Trim(), txtLink.Text.Trim());
            Close();
        }
    }
}
