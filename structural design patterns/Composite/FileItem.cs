using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.structural_design_patterns.Composite
{
    public class FileItem : FileSystemItem
    {
        private readonly long _size;

        public FileItem(string name, long size) : base(name)
        {
            _size = size;
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + Name);
        }

        public override long GetSize()
        {
            return _size;
        }
    }
}
