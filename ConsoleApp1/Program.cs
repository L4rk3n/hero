using ConsoleApp1.Chapitres;
using ConsoleApp1.Dessins;
using ConsoleApp1.Textes;
using System;
using System.Reflection;
using System.Text;

class Program

{
    static void Main(string[] args)

    {

        bool death = false;
        bool theend = false;
        int nextChap = 1;
        int node = 1;
        Dessin crayon = new Dessin ();



        Textes roman = new Textes();
        Chapitre histoire = new Chapitre();

        Delegate[] dessins = new Delegate[]
{
        crayon.Dessin1,
        crayon.Dessin2
};

        Delegate[] chapitres = new Delegate[]
        {
        (Func<int>)histoire.Chapitre1,
        (Func<int>)histoire.Chapitre2,
        (Func<int>)histoire.Chapitre3,
        (Func<int>)histoire.Chapitre4
        };

        do
        {
            //dessins[dessin(nextChap - 1)]();
            int chapTemp = (int)chapitres[nextChap-1].DynamicInvoke();
            nextChap = chapTemp;

        } while (death == false || theend == false );
    }
}


