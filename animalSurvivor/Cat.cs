﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace animalSurvivor
{
    internal class Cat : Animal
    {
        const int SPRITEWIDTH = 32;
        const int SPRITEHEIGHT = 32;

        public Cat(Form form)
        {
            _form = form;
            PB = MakePictureBox();
            _form.Controls.Add(PB);
            Cells = MakeSpriteCell();
        }
        protected override PictureBox MakePictureBox()
        {
            Random rnd = new Random();
            PictureBox pb = new PictureBox()
            {
                Location = new Point(rnd.Next(_form.Width - 10), rnd.Next(_form.Height - 10)),
                Size = new Size(SPRITEWIDTH, SPRITEHEIGHT),
            };
            return pb;
        }

        protected override List<Bitmap> MakeSpriteCell()
        {
            List<Bitmap> rtnList = new();
            Bitmap img = Form1._animalSprite["cat"];
            for (int i = 0; i < ROWCNT; i++)
            {
                for (int x = 0; x < COLCNT; x++)
                {
                    Rectangle cellRect = new(SPRITEWIDTH * x, SPRITEHEIGHT * i, SPRITEWIDTH, SPRITEHEIGHT);
                    var cell = img.Clone(cellRect, System.Drawing.Imaging.PixelFormat.DontCare);
                    rtnList.Add(cell);
                }
            }
            return rtnList;
        }
    }
}
