using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.module
{
    public class Dice
    {
        public int Rolldice(int nbrde, int nbrface)
        {
            Random dice = new Random();
            int result = 0;
            int temp = 0;
            for (int i = 1; i <= nbrde; i++)
                temp = dice.Next(1, nbrface);
            if (temp > result) result = temp;
            return result;
        }
    }
}
