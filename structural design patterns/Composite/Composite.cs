using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.structural_design_patterns.Composite
{
    internal class Composite
    {
        public static void Run()
        {
            var root = new Folder("Root");

            var file1 = new FileItem("File1.txt", 100);
            var file2 = new FileItem("File2.txt", 200);

            var subFolder = new Folder("SubFolder");
            subFolder.Add(new FileItem("File3.txt", 300));

            root.Add(file1);
            root.Add(file2);
            root.Add(subFolder);

            root.Display(1);

            Console.WriteLine($"Total Size: {root.GetSize()}");
        }
    }
}
