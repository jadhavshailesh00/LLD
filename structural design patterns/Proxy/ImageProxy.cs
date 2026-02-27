using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.structural_design_patterns.Proxy
{
    public class ImageProxy : IImage
    {
        private readonly string _fileName;
        private RealImage _realImage;

        public ImageProxy(string fileName)
        {
            _fileName = fileName;
        }

        public void Display()
        {
            if (_realImage == null)
            {
                _realImage = new RealImage(_fileName);
            }

            _realImage.Display();
        }
    }
}
