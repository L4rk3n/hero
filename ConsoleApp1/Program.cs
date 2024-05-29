using ConsoleApp1.Chapitres;
using ConsoleApp1.module;
using ConsoleApp1.Dessins;
using ConsoleApp1.Fiches;
using System;
using System.Reflection;
using System.Text;
using ConsoleApp1.Texte;
using System.Media;

class Program

{
    static void Main(string[] args)

    {
        Audio player = new Audio();
        Console.SetWindowSize(150, 50);
        Dessin crayon = new Dessin();
        Textes roman = new Textes();
        Combat fight = new Combat();
        Pnj portrait = new Pnj(); 

        bool theend = false;
        int nextChap = 1;
        int node = 1;
        string answer = "";

        Chapitre histoire = new Chapitre();
        Hero hero;

        player.playIntro();
        crayon.dessins[0].DynamicInvoke();
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine($" Avante de démarrer voici quelques règles à suivre pour progresser\n - Lorsque le jeu vous pose une question ou vous offfre un choix repondez lui et appuyez sur la touchee (entrée) \n - Si le jeu est pausé mais ne requiert aucun choix,prenez le temps de lire et appuyer simplement sur (entrée) \nBon jeu à vous !");
        Console.ReadLine();
        Console.Clear();

        portrait.Dessinpnj("choixperso");
        string affichage = roman.dictionnaire[0];
        Console.WriteLine(affichage);
        do
        {

            Console.WriteLine("Quelle race voulez vous jouer ? elfe(1)ou nain (2)");
            answer = Console.ReadLine();
        } while ((answer != "1") && (answer != "2"));

        if (answer == "1")
        {
            hero = new Elfe();
            hero.Creation();
        }
        else
        {
            hero = new Nain();
            hero.Creation();
        }
        hero.AfficherInfos();

        do
        {
            Console.Clear (); 
            crayon.dessins[nextChap].DynamicInvoke();
            affichage = roman.dictionnaire[nextChap];
            Console.WriteLine(affichage);
            int chapTemp = (int)histoire.chapitres[nextChap].DynamicInvoke(hero);
            nextChap = chapTemp;

        } while ( !hero.Mort );

        if (hero.Mort is true) Console.WriteLine("Perdu boulet !");
        if (hero.Mort is false) Console.WriteLine("Bravo tu es arrivé au bout!, et quoi tu veux un cadeau ?");
        
    }
}


