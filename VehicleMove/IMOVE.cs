using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMove
{
    internal interface IMOVE
    {
        public int Speed { get; set; }
        public void MoveLeft() { }
        public void MoveRight() { }
        public void MoveUp() { }
        public void MoveDown() { }
        public void MoveLeftUp() { }
    }
}
