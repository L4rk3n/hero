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
        Chapitre11,
        Chapitre12,
        Chapitre13,
        Chapitre14,
        Chapitre15,
        Chapitre16,
        Chapitre17,
        Chapitre18,
        Chapitre19,
        Chapitre20,
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
            Console.ReadLine();
            int choix = 6;
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
            player.playWind();
            int choix = DemanderChoix(new int[] { 11,12});
            return choix;
        }
        public int Chapitre11(Fiches.Hero Hero)
        {
            Dice dede = new Dice();
            Combat combat = new Combat();
            player.playWind();

            for (int i = 1; i <= 4; i++)
            {
                if ((dede.Rolldice(1, 6) < 3) && (!Hero.Mort))
                {
                    Console.WriteLine("Votre progression est stoppée net par l'apparition d'un ennemi");
                    Console.ReadLine();
                    player.playNormal();
                    combat.Combatexe(Hero);
                }
                if (!Hero.Mort) Console.WriteLine("Vous reprenez la route");
            }
            Console.ReadLine();
            int choix = 14;
            return choix;
        }
        public int Chapitre12(Fiches.Hero Hero)
        {
            Dice dede = new Dice();
            Combat combat = new Combat();
            player.playWind();

            for (int i = 1; i <= 2; i++)
            {
                if ((dede.Rolldice(1, 6) < 3) && (!Hero.Mort))
                {
                    Console.WriteLine("Votre progression est stoppée net par l'apparition d'un ennemi");
                    Console.ReadLine();
                    player.playNormal();
                    combat.Combatexe(Hero);
                    if (!Hero.Mort) Console.WriteLine("Vous reprenez la route");
                }
            }
            Console.ReadLine();
            int choix = 13;
            return choix;
        }
        public int Chapitre13(Fiches.Hero Hero)
        {
            player.playWind();
            bool tomber = false;
            Dice dede = new Dice();
            Event rencontre = new Event();
            int i = 1;
            do
            {
                if ((dede.Rolldice(1, 6) < 3) && (!tomber))
                {
                    Console.WriteLine("Votre progression est stoppée par un trou devant vous");
                    Console.ReadLine();
                    tomber = rencontre.pontAgi(Hero);
                }
                i += 1;
            } while ((i < 3) || (!tomber));
            if (tomber)
            {
                int degat = dede.Rolldice(1, 3);
                player.playFall();
                Console.WriteLine($"Vous tombez du pont et faites une chute douloureuse qui vous inflige {degat} ");
                Hero.Pv -= degat;

                if (Hero.Pv < 0)
                {
                    player.playCrit();
                    Console.WriteLine("Vous êtes tué par la chute !");
                    Hero.Mort = true;
                }
                else Console.WriteLine("Vou parvenez tant bien que mal à vous relevez et à ressortir de la crevasse de l'autre côté");
            }
            else Console.WriteLine("Vous reprenez votre chemin");
            Console.ReadLine();
            int choix = 14;
            return choix;
        }
        public int Chapitre14(Fiches.Hero Hero)
        {
            Combat combat = new Combat();
            Dice dede = new Dice();
            player.playCampfire();
            Console.ReadLine();
            for (int i = 1; i <= 2; i++)
            {
                if ((dede.Rolldice(1, 6) < 3) && (!Hero.Mort))
                {
                    Console.WriteLine("Vous êtes réveillé par des bruits supspects et un ennemi sort des ombres");
                    Console.ReadLine();
                    player.playNormal();
                    combat.Combatexe(Hero);
                    if (!Hero.Mort) Console.WriteLine("Vous vous recouchez en esperant ne plus être dérangé ");
                }
            }
            int choix = 15;
            return choix;
        }
        public int Chapitre15(Fiches.Hero Hero)
        {
            Event rencontre = new Event();
            rencontre.miniDonjon(Hero);
            player.playWind();
            int choix = 16;
            return choix;
        }
        public int Chapitre16(Fiches.Hero Hero)
        {
            player.playWind();
            int choix = DemanderChoix(new int[] { 2, 3, 4 });
            return choix;
        }
        public int Chapitre17(Fiches.Hero Hero)
        {
            player.playWind();
            int choix = DemanderChoix(new int[] { 2, 3, 4 });
            return choix;
        }
        public int Chapitre18(Fiches.Hero Hero)
        {
            player.playWind();
            int choix = DemanderChoix(new int[] { 2, 3, 4 });
            return choix;
        }
        public int Chapitre19(Fiches.Hero Hero)
        {
            player.playWind();
            int choix = DemanderChoix(new int[] { 2, 3, 4 });
            return choix;
        }
        public int Chapitre20(Fiches.Hero Hero)
        {
            player.playWind();
            int choix = DemanderChoix(new int[] { 2, 3, 4 });
            return choix;
        }
    }
}