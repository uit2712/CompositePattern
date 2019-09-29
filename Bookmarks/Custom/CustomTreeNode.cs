using Bookmarks.Components;
using System.Windows.Forms;

namespace Bookmarks.Custom
{
    class CustomTreeNode : TreeNode
    {
        public Component Component { get; set; }

        public CustomTreeNode(Component component)
        {
            Component = component;
            base.Text = component?.Name;
            if (component != null)
            {
                if (component.IsPage())
                    SelectedImageIndex = ImageIndex = 2;
                else
                {
                    SelectedImageIndex = 1;
                    ImageIndex = 0;
                }
            }
        }
    }
}
