using ConsoleApp1.Dessins;
using ConsoleApp1.Textes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.Chapitres
{
    public class Chapitre

    {
        public static int DemanderChoix(int[] options)
        {
            bool estValide = false;

            Console.WriteLine("Quel chemin prenez vous ?" + string.Join(", ", options));  
            string entree = Console.ReadLine();
            int choix = int.Parse(entree);
            do
            {
                if (Array.Exists(options, option => option == choix))
                {
                    estValide = true;
                }
                else Console.WriteLine("Chemin non valide");
            } while (!estValide);

            return choix;
        }

        public int Chapitre1()
        {
            //string affichage = Value(base.roman(base.nextchap));
            //Console.WriteLine("debut de l'aventure");
            int choix =DemanderChoix(new int[] { 2,3,4 });
            return choix;
        }
        public int Chapitre2()
        {
            Console.WriteLine("promenade par la foret");
            int choix = DemanderChoix(new int[] { 2, 3, 4 });
            return choix;
        }
        public int Chapitre3()
        {
            Console.WriteLine("suivre la grand route");
            int choix = DemanderChoix(new int[] { 2, 3, 4 });
            return choix;
        }
        public int Chapitre4()
        {
            Console.WriteLine("prendre le bateau");
            int choix = DemanderChoix(new int[] { 2, 3, 4 });
            return choix;
        }

    }
}
