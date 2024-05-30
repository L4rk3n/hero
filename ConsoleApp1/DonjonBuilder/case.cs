using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DonjonBuilder
{
    public class Case
    {
        public int Valeur { get; set; }
        public string Apparence { get; set; }

        public Case(int valeur, string apparence)
        {
            Valeur = valeur;
            Apparence = apparence;
        }
    }

}