﻿using System;
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
        public FileInfo ImageFile { get; private set; }
        public Image Image { get; private set; }

        public ImageActor(FileInfo path)
        {
            this.ImageFile = path;
            this.Image = Bitmap.FromFile(this.ImageFile.FullName);
        }

        public Color getBitColor(int x, int y)
        {
            return (new Bitmap(this.Image)).GetPixel(x, y);
        }



    }
}
