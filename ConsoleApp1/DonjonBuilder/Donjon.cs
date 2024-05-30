
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
                Console.WriteLine();
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
        public Location DeplacerHero(ConsoleKeyInfo keyInfo,Location location,Donjon donjon)
        {
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