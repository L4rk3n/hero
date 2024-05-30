using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DonjonBuilder
{
    public class Location
    {
        public int PosX { get; set; }
        public int PosY { get; set; }

        public Location(int posX, int posY)
        {
            PosX = posX;
            PosY = posY;
        }
    }
}
