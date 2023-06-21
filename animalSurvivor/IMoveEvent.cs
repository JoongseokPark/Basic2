using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalSurvivor
{
    internal interface IMoveEvent
    {
        void KeyDown(object sender, KeyEventArgs e);
        void KeyUp(object sender, KeyEventArgs e);
        void Timer_Tick(object sender, EventArgs e);
    }
}
