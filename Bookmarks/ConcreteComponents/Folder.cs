using Bookmarks.Components;
using System.Collections.Generic;

namespace Bookmarks.ConcreteComponents
{
    /// <summary>
    /// Composite
    /// </summary>
    class Folder : Component
    {
        protected Dictionary<int, Component> _components = new Dictionary<int, Component>();
        protected int _currentId = 0;

        public Folder(int id, string name)
            : base(id, name)
        {

        }

        public override void Add(Component component)
        {
            if (_components != null)
                _components[_currentId++] = component;
        }

        public override bool HasChild()
        {
            return _components.Count > 0;
        }

        public override bool IsPage()
        {
            return false;
        }

        public override void Remove(Component component)
        {
            if (component != null && _components.ContainsKey(component.Id))
                _components.Remove(component.Id);
        }
    }
}
