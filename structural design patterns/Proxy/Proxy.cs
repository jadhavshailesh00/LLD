using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.structural_design_patterns.Proxy
{
    internal class Proxy
    {
        public static void  Run()
        {
            IImage image = new ImageProxy("photo.jpg");

            // Image not loaded yet
            image.Display(); // Loads and displays
            image.Display(); // Only displays
        }
    }
}
