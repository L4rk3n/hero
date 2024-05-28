using ConsoleApp1.Dessins;
using ConsoleApp1.Fiches;
using ConsoleApp1.module;
using ConsoleApp1.Texte;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Media;

namespace ConsoleApp1.Chapitres
{
    public class Chapitre

    {
        
        public Chapitre()
        {
            chapitres = new Delegate[]
        {
        Chapitre0,
        Chapitre1,
        Chapitre2,
        Chapitre3,
        Chapitre4,
        Chapitre5,
        Chapitre6,
        Chapitre7,
        Chapitre8,
        Chapitre9,
        Chapitre10,
        };
        }
        Audio player = new Audio();
        public Delegate[] chapitres { get; set; }
        public static int DemanderChoix(int[] options)


        {
            bool estValide = false;

            int choix = 1000;
            do
            {
                Console.WriteLine("Quel est votre choix ?" + string.Join(", ", options));
                string entree = Console.ReadLine();
                int.TryParse(entree,out choix);
                if (Array.Exists(options, option => option == choix))
                {
                    estValide = true;
                }
                else Console.WriteLine("Chemin non valide");
            } while (!estValide);
            Console.Clear();

            return choix;
        }

        public int Chapitre0(Fiches.Hero Hero)
        {
            int choix =DemanderChoix(new int[] { 2,});
            return choix;
        }
        public int Chapitre1(Fiches.Hero Hero)
        {
            player.playInnn();
            int choix = DemanderChoix(new int[] { 2, 3});
            return choix;
        }
        public int Chapitre2(Fiches.Hero Hero)
        {
            player.playWoods();
            Console.ReadLine();
            Combat combat = new Combat();
            combat.Combatexe(Hero);
            Hero.AfficherInfos();
            int choix = 4;

            return choix;
        }
        public int Chapitre3(Fiches.Hero Hero)
        {
            Dice dede= new Dice();
            Combat combat = new Combat();
            player.playHorse();
            if (dede.Rolldice(1, 6) < 3)
            {
                Console.WriteLine("Votre progression est stoppée net par l'apparition d'un ennemi");
                Console.ReadLine();
                player.playNormal();
                combat.Combatexe(Hero);
                if (!Hero.Mort) Console.WriteLine("Vous reprenez la route jusqu'a destination");
            }
            Console.ReadLine();
            int choix = 4;
            return choix;
        }
        public int Chapitre4(Fiches.Hero Hero)
        {            
            player.playTown();
            int choix = DemanderChoix(new int[] { 5,6});
            return choix;
        }
        public int Chapitre5(Fiches.Hero Hero)
        {
            Event rencontre = new Event();
            player.playTown();
            Console.ReadLine();
            rencontre.marchandPotion(Hero);
            int choix = DemanderChoix(new int[] {6});
            return choix;
        }
        public int Chapitre6(Fiches.Hero Hero)
        {
            player.playTown();
            int choix = DemanderChoix(new int[] { 7, 8, 9 });
            return choix;
        }
        public int Chapitre7(Fiches.Hero Hero)
        {
            player.playTown();
            int choix = DemanderChoix(new int[] {8,9});
            return choix;
        }
        public int Chapitre8(Fiches.Hero Hero)
        {
            player.playTown();
            int choix = DemanderChoix(new int[] {7,9,10 });
            return choix;
        }
        public int Chapitre9(Fiches.Hero Hero)
        {
            player.playTown();
            int choix = DemanderChoix(new int[] { 7,8});
            return choix;
        }
        public int Chapitre10(Fiches.Hero Hero)
        {
            player.playWoods();
            int choix = DemanderChoix(new int[] { 2, 3, 4 });
            return choix;
        }
    }
}
