using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Textes
{
    public class Textes
    {
        private Dictionary<int, string> dictionnaire;

        public Textes()
        {
                dictionnaire = new Dictionary<int, string>
                {
                    { 1, "Première valeur" },
                    { 2, "Deuxième valeur" },
                    { 3, "Troisième valeur" }
                };
        }

    }
}
