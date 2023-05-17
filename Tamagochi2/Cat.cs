using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.PeerToPeer;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tamagochi2
{
    internal class Cat
    {
        
        Label _label;
        PictureBox _pb;
        ComboBox _cb;

        public string? Name { get; set; }

        public Cat(string name, int x, int y)
        {
            Name = name;
            Pn = MakePanel(x, y);
            _label = MakeLabel();
            _pb = MakePicture();
            _cb = MakeCombobox();
            Pn.Controls.Add(_label);
            Pn.Controls.Add(_pb);
            Pn.Controls.Add(_cb);
            Idle();
            _label.Text = Name;
        }

        public Panel Pn { get; }

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
            lbl.Size = new Size(80, 24);
            return lbl;
        }
        private PictureBox MakePicture()
        {
            PictureBox pb = new();
            pb.Location = new Point(5, 29);
            pb.Size = new Size(200, 200);

            return pb;
        }

        private System.Windows.Forms.ComboBox MakeCombobox()
        {
            string[] emos = { "idle", "cry", "feed", "happy", "hungry", "sleep" };

            System.Windows.Forms.ComboBox cb = new();
            cb.Location = new Point(85, 5);
            cb.Items.AddRange(emos);
            cb.SelectedIndex = 0;
            cb.SelectedIndexChanged += SelectedIndexChanged;

            return cb;
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

        private void SelectedIndexChanged(object? sender, EventArgs e)
        {
            _label.Text = _cb.SelectedItem.ToString();
            switch (_cb.SelectedIndex)
            {
                case 0:
                    Idle();
                    break;
                case 1:
                    Cry();
                    break;
                case 2:
                    Feed();
                    break;
                case 3:
                    Happy();
                    break;
                case 4:
                    Hungry();
                    break;
                case 5:
                    Sleep();
                    break;

            }
        }
    }
}
