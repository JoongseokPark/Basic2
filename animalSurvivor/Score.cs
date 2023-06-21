using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalSurvivor
{
    internal class Score : Singleton<Score>
    {
        public Label ScoreLB { get; set; }
        Form _frm;
        int _score = 0;

        public void Init(Form frm)
        {
            _frm = frm;
            ScoreLB = MakeScoreLabel();
            _frm.Controls.Add(ScoreLB);
        }

        private Label MakeScoreLabel()
        {
            Label label = new Label();
            if(_frm != null)
            {
                Font LargeFont = new("Arial", 18, FontStyle.Italic);

                label.Location = new Point(_frm.Width - 200, 2);
                label.Font = LargeFont;
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.Size = new Size(400, 25);
                label.ForeColor = Color.SkyBlue;
                label.Text = "Score";
            }
            return label;
        }

        public void AddScore()
        {
            _score += 10;
            if(ScoreLB != null)
            {
                ScoreLB.Text = "Score : " + _score.ToString();
            }
        }
    }
}
