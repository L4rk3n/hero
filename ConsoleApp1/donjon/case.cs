using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Donjon
{
    public class Case
    {
        public string Valeur { get; set; }
        public string Apparence { get; set; }

        public Case(string valeur, string apparence)
        {
            Valeur = valeur;
            Apparence = apparence;
        }

        public static Case[,] CreerDonjon(int lignes, int colonnes)
        {
            Case[,] donjon = new Case[lignes, colonnes];

            for (int i = 0; i < lignes; i++)
            {
                for (int j = 0; j < colonnes; j++)
                {
                    donjon[i, j] = new Case( " ", " ");
                }
            }

            return donjon;
        }

    }

}