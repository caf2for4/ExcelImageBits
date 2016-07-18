using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelImageBits.Actor
{
    class ImageActor
    {
        public string ImageFile { get; private set; }
        public Image Image { get; private set; }

        public ImageActor(string path)
        {
            this.ImageFile = path;
            this.Image = Bitmap.FromFile(this.ImageFile);
        }

        public bool InRangeSize
        {
            get
            {
                if (this.Image.Size.Width <= 16384 && this.Image.Size.Height <= 1048576)
                {
                    return true;
                }

                return false;
            }
        }

        public Color getBitColor(int x, int y)
        {
            return (new Bitmap(this.Image)).GetPixel(x, y);
        }



    }
}
