namespace LLD.structural_design_patterns.Composite
{
    public abstract class FileSystemItem
    {
        public string Name { get; }

        protected FileSystemItem(string name)
        {
            Name = name;
        }

        public abstract void Display(int depth);
        public abstract long GetSize();
    }
}
