
using ConsoleApp1.Fiches;
using ConsoleApp1.module;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1.DonjonBuilder
{
    public class Donjon
    {
        public int Taille { get; init; }
        private Case[,] donjon ;
        public Case this[int x, int y]
        {
            get { return donjon[x, y]; }
        }

        public Donjon(int taille)
        {
            Taille = taille;
            donjon = new Case[taille, taille];
        }
        public void RemplirDonjon()
        {
            for (int i = 0; i < donjon.GetLength(0); i++)
            {
                for (int j = 0; j < donjon.GetLength(1); j++)
                {
                    donjon[i, j] = new Case(0,"   ");
                }
            }
            for (int k = 0; k < donjon.GetLength(0); k++)
            {
                donjon[0, k] = new Case(5, "---");
                donjon[donjon.GetLength(0)-1, k] = new Case(5, "---");
            }
            for (int l = 0; l < donjon.GetLength(1)-1; l++)
            {
                donjon[l, 0] = new Case(4, " | ");
                donjon[l,donjon.GetLength(0) - 1] = new Case(5, " | ");
            }

            donjon[1,1] = new Case(4," H ");
            donjon[13, 13] = new Case(3, " s ");

        }
        public void AfficherDonjon()
        {
            Console.Clear();
            
            for (int i = 0; i < donjon.GetLength(0); i++)
            {
                Console.SetCursorPosition(10, 10 + i);
                for (int j = 0; j < donjon.GetLength(1); j++)
                {
                    
                    Console.Write(donjon[i, j].Apparence);
                }               
            }
            Console.SetCursorPosition(60,10);
            Console.WriteLine(" Déplacez-vous avec les flêches du clavier");
            Console.SetCursorPosition(60,11);
            Console.WriteLine(" Recupérer l'or sur les cases G");
            Console.SetCursorPosition(60,12);
            Console.WriteLine(" Affronter les monstres sur les cases M");
            Console.SetCursorPosition(60,13);
            Console.WriteLine(" Recupérer l'or sur les cases G");
            Console.SetCursorPosition(60,14);
            Console.WriteLine(" Prener la sortie sur la cases S");
        }
        public void PeuplerDonjon(Donjon donjon)
        {
            Dice dede = new Dice();
            int nombreM = 4 + dede.Rolldice(1, 4);
            int nombreG = 3 + dede.Rolldice(1, 3);
            int posx = 0;
            int posy = 0;
            for (int i = 1; i < nombreM; i++)
            {
                bool transfert = false;
                do
                {
                    posx = dede.Rolldice(1, donjon.Taille);
                    posy = dede.Rolldice(1, donjon.Taille);
                    if (donjon[posx, posy].Valeur < 1)
                    {
                        transfert = true;
                        donjon[posx, posy].Valeur = 1;
                        donjon[posx, posy].Apparence = " M ";
                    }
                } while (!transfert);
               
            }
            for (int i = 1; i < nombreG; i++)
            {
                bool transfert = false;
                do
                {
                    posx = dede.Rolldice(1, donjon.Taille);
                    posy = dede.Rolldice(1, donjon.Taille);
                    if (donjon[posx, posy].Valeur < 1)
                    {
                        transfert = true;
                        donjon[posx, posy].Valeur = 2;
                        donjon[posx, posy].Apparence = " G ";
                    }
                } while (!transfert);

            }
        }

        public void MurerDonjon1()
        {
            for (int i = 4; i < 12; i++)
            {
                donjon[i,2] = new Case(5, " | ");
            }
            for (int i = 3; i < 7; i++)
            {
                donjon[i,6] = new Case(5, " | ");
            }
            for (int i = 8; i < 11; i++)
            {
                donjon[i,6] = new Case(5, " | ");
            }
            for (int i = 3; i < 12; i++)
            {
                donjon[i,11] = new Case(5, " | ");
            }
            for (int i = 2; i < 12; i++)
            {
                donjon[2,i] = new Case(5, "---");
            }
            for (int i = 3; i < 10; i++)
            {
                donjon[11, i] = new Case(5, "---");
            }

        }
        public Location DeplacerHero(ConsoleKeyInfo keyInfo,Location location,Donjon donjon,Hero hero)
        {
            Dice dede = new Dice();
            int newX = location.PosX;
            int newY = location.PosY;
            Location newLocation = new Location(newX,newY);

            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    newX -= 1;
                    break;
                case ConsoleKey.DownArrow:
                    newX += 1;
                    break;
                case ConsoleKey.LeftArrow:
                    newY -= 1;
                    break;
                case ConsoleKey.RightArrow:
                    newY += 1;
                    break;
            }
            switch (donjon[newX, newY].Valeur)
            {
                case 1:

                    Combat combat = new Combat();
                    Console.SetCursorPosition(60, 16);
                    Console.WriteLine("Vous tombez nez à nez avec un monstre");
                    Console.SetCursorPosition(60, 17);
                    Console.WriteLine("Appuyer sur entrée pour continuer");
                    Console.ReadLine();
                    combat.Combatexe(hero); 
                    break;
                case 2:
                    int gainor = dede.Rolldice(1,6) ;
                    Console.SetCursorPosition(60, 15);
                    Console.WriteLine($"Vous gagner {gainor} pièces d'or");
                    hero.Gold += gainor;
                    Console.SetCursorPosition(60, 16);
                    Console.WriteLine($"Ce qui vous fait un total de {hero.Gold} pièces d'or");
                    Console.SetCursorPosition(60, 17);
                    Console.WriteLine("Appuyer sur entrée pour continuer");
                    Console.ReadLine();
                    break;
            }
            if (donjon[newX, newY].Valeur < 5)
            {
                donjon[newX, newY].Valeur = 4;
                donjon[newX, newY].Apparence = " H ";
                donjon[location.PosX, location.PosY].Valeur = 0;
                donjon[location.PosX, location.PosY].Apparence = "   ";
                newLocation.PosX = newX;
                newLocation.PosY = newY;
            }

            return newLocation;

        }

    }
}