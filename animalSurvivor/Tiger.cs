using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace animalSurvivor
{
    internal class Tiger: Animal
    {
        const int SPRITEWIDTH = 56;
        const int SPRITEHEIGHT = 56;

        public Tiger(Form form)
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
                Location = new Point(rnd.Next(_form.Width), rnd.Next(_form.Height)),
                Size = new Size(SPRITEWIDTH, SPRITEHEIGHT),
            };
            return pb;
        }

        protected override List<Bitmap> MakeSpriteCell()
        {
            List<Bitmap> rtnList = new();
            Bitmap img = Form1._animalSprite["tiger"];
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
