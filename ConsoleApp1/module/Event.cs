using ConsoleApp1.Fiches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using ConsoleApp1.Dessins;

namespace ConsoleApp1.module
{
    public class Event
    {
        Audio player = new Audio();

        public void marchandPotion(Hero Hero)
        {
            Pnj adversaire = new Pnj();
            Console.Clear();
            player.playBubbles();
            adversaire.Dessinpnj("potionmaster");
            string answer = "";
            do
            {
                Console.WriteLine($"Bonjour aventurier combien de potion de soin voulez-vous(prix unitaire: 10 pièces d'or)?\nIl vous reste {Hero.Gold}");
                string entree = Console.ReadLine();
                int.TryParse(entree, out int quant);
                if (quant * 10 < Hero.Gold)
                {
                    Hero.Gold -= quant * 10;
                    Hero.Potion += quant;
                    Console.WriteLine($" Vous acheter {quant} potions, vous avez donc {Hero.Potion} potion de soins\n Et il vous reste {Hero.Gold} pièces d'or");
                }
                else Console.WriteLine($"Vous n'avez que {Hero.Gold} pièces d'or, ce n'est pas suffisant!");
                do
                {
                    Console.WriteLine($"Voulez vous acheter autre chose ? 0/n");
                    answer = Console.ReadLine();
                } while ((answer != "0") && (answer != "n"));
            } while (answer != "n");
            Console.WriteLine("Il est temps de reprendre votre route !");
            Console.ReadLine();
        }
    }

}
