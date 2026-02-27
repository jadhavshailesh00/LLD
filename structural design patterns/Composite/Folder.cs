namespace LLD.structural_design_patterns.Composite
{
    public class Folder : FileSystemItem
    {
        private readonly List<FileSystemItem> _children =
            new List<FileSystemItem>();

        public Folder(string name) : base(name) { }

        public void Add(FileSystemItem item)
        {
            _children.Add(item);
        }

        public void Remove(FileSystemItem item)
        {
            _children.Remove(item);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + Name);

            foreach (var child in _children)
            {
                child.Display(depth + 2);
            }
        }

        public override long GetSize()
        {
            return _children.Sum(child => child.GetSize());
        }
    }
}
