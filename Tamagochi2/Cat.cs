using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi2
{
    internal class Cat
    {
        Panel _pn;
        Label _label;
        PictureBox _pb;
        string? _name;

        public string Name
        {
            get 
            { 
                return _name; 
            }
            set 
            {
                _name = value; 
                _label.Text = _name;
            }
        }
        public Cat(string Name,int x, int y)
        {
            _name = Name;
            _pn = MakePanel(x,y);
            _label = MakeLabel();
            _pb = MakePicture();
            _pn.Controls.Add(_label);
            _pn.Controls.Add(_pb);
            Idle();
            _label.Text = _name;
        }

        public Panel GetPanel()
        {
            return _pn;
        }

        private Panel MakePanel(int x, int y)
        {
            Panel panel = new Panel();
            panel.Location = new Point(x, y);
            panel.Size = new Size(210, 230);

            return panel;
        }
        private Label MakeLabel()
        {
            Label lbl = new();
            lbl.Location = new Point(5,5);

            return lbl;
        }
        private PictureBox MakePicture()
        {
            PictureBox pb = new();
            pb.Location = new Point(5, 24);
            pb.Size = new Size(200, 200);

            return pb;
        }

        public void Idle()
        {
            _pb.Image = Image.FromFile("C:\\Works\\Parkjs\\Tamagochi2\\Images\\cat_idle.gif");
        }
        public void Sleep()
        {
            _pb.Image = Image.FromFile("C:\\Works\\Parkjs\\Tamagochi2\\Images\\cat_sleep.gif");
        }
        public void Cry()
        {
            _pb.Image = Image.FromFile("C:\\Works\\Parkjs\\Tamagochi2\\Images\\cat_cry.gif");
        }
        public void Hungry()
        {
            _pb.Image = Image.FromFile("C:\\Works\\Parkjs\\Tamagochi2\\Images\\cat_hungry.gif");
        }
        public void Happy()
        {
            _pb.Image = Image.FromFile("C:\\Works\\Parkjs\\Tamagochi2\\Images\\cat_happy.gif");
        }
        public void Feed()
        {
            _pb.Image = Image.FromFile("C:\\Works\\Parkjs\\Tamagochi2\\Images\\cat_feed.gif");
        }
    }
}
