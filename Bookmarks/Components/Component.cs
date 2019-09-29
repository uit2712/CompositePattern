namespace Bookmarks.Components
{
    public abstract class Component
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Component(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public abstract void Add(Component component);
        public abstract void Remove(Component component);
        public abstract bool IsPage();
        public abstract bool HasChild();
    }
}
