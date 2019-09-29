using Bookmarks.Components;
using System.Windows.Forms;

namespace Bookmarks.ConcreteComponents
{
    class Page : Component
    {
        public string Link { get; set; }

        public Page(int id, string name, string link)
            : base(id, name)
        {
            Link = link;
        }

        public override void Add(Component component)
        {
            
        }

        public override void Remove(Component component)
        {
            
        }

        public void EnterPage()
        {
            MessageBox.Show(string.Format("Enter page: '{0}'", Link));
        }

        public override bool IsPage()
        {
            return true;
        }

        public override bool HasChild()
        {
            return false;
        }
    }
}
