using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Dessins
{
    public class Dessin
    {
        public Dessin()
        {
            dessins = new Delegate[]
        {
            Dessin0,
            Dessin1,
            Dessin2,
            Dessin3,
            Dessin4,
            Dessin5,
            Dessin6,
            Dessin7,
            Dessin8,
            Dessin9,
            Dessin10,
            Dessin11,
            Dessin12,
            Dessin13,
            Dessin14,
            Dessin15,
        };
        }
        public Delegate[] dessins { get; set; }
        
        public void Dessin0()
        {
            // Console.SetCursorPosition(10, 20);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("   _______  _______  _______ __________________                     _______  _______  _______  _______  _______   ");
            sb.AppendLine("  (  ___  )(  ____\\ (  ____ \\\\__   __/\\__   __/           |\\     /|(  ____ \\(  ____ )(  ___  )(  ____ \\(  ____ \\  ");
            sb.AppendLine("  | (   ) || (    \\/| (    \\/   ) (      ) (              | )   ( || (    \\/| (    )|| (   ) || (    \\/| (    \\/  ");
            sb.AppendLine("  | (___) || (_____ | |         | |      | |      _____   | (___) || (__    | (____)|| |   | || (__    | (_____   ");
            sb.AppendLine("  |  ___  |(_____  )| |         | |      | |     (_____)  |  ___  ||  __)   |     __)| |   | ||  __)   (_____  )  ");
            sb.AppendLine("  | (   ) |      ) || |         | |      | |              | (   ) || (      | (\\ (   | |   | || (            ) |  ");
            sb.AppendLine("  | )   ( |/\\____) || (____/\\___) (______) (___           | )   ( || (____/\\| ) \\ \\__| (___) || (____/\\/\\____) |  ");
            sb.AppendLine("  |/     \\|\\_______)(_______/\\_______/\\_______/           |/     \\|(_______/|/   \\__/(_______)(_______/\\_______)  ");

            Console.WriteLine(sb.ToString());
            Console.WriteLine("                                  APPUYEZ SUR ENTER POUR CONTINUER");

        }
        public void Dessin1() 
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("                                   /\\");
            sb.AppendLine("                              /\\  //\\\\");
            sb.AppendLine("                       /\\    //\\\\///\\\\\\        /\\");
            sb.AppendLine("                      //\\\\  ///\\////\\\\\\\\  /\\  //\\\\");
            sb.AppendLine("         /\\          /  ^ \\/^ ^/^  ^  ^ \\/^ \\/  ^ \\");
            sb.AppendLine("        / ^\\    /\\  / ^   /  ^/ ^ ^ ^   ^\\ ^/  ^^  \\");
            sb.AppendLine("       /^   \\  / ^\\/ ^ ^   ^ / ^  ^    ^  \\/ ^   ^  \\       *");
            sb.AppendLine("      /  ^ ^ \\/^  ^\\ ^ ^ ^   ^  ^   ^   ____  ^   ^  \\     /|\\");
            sb.AppendLine("     / ^ ^  ^ \\ ^  _\\___________________|  |_____^ ^  \\   /||o\\");
            sb.AppendLine("    / ^^  ^ ^ ^\\  /______________________________\\ ^ ^ \\ /|o|||\\");
            sb.AppendLine("   /  ^  ^^ ^ ^  /________________________________\\  ^  /|||||o|\\");
            sb.AppendLine("  /^ ^  ^ ^^  ^    ||___|___||||||||||||___|__|||      /||o||||||\\");
            sb.AppendLine(" / ^   ^   ^    ^  ||___|___||||||||||||___|__|||          | |");
            sb.AppendLine("/ ^ ^ ^  ^  ^  ^   ||||||||||||||||||||||||||||||oooooooooo| |ooooooo");
            sb.AppendLine("ooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo");
            sb.AppendLine("");
            sb.AppendLine("");

            Console.WriteLine(sb.ToString());
        }
        public void Dessin2()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("/\\");
            sb.AppendLine("%%\\            ,       ");
            sb.AppendLine("%%%\\          ,~,                /\\   ");
            sb.AppendLine("%%%\\         ,~~~,   /\\         /%%\\  /\\");
            sb.AppendLine("%%%%\\  /\\   ,~~~~~, /%%\\   /\\   /%%\\ /%%");
            sb.AppendLine("%%%%\\ /%%\\ /\\~~~~~~/%%%%\\ /%%\\ /%%%%\\/%%");
            sb.AppendLine("%%%%%\\/%%\\/%%\\~/\\~~/%%%%\\/%%%%/%%%%%%\\%%");
            sb.AppendLine("%/\\%%/%%%%\\%%%/%%\\/%%%%%%\\%%/\\/%%/\\%%\\%%");
            sb.AppendLine("/%%\\/%%%%%%\\/\\/%%\\/%%%%%%\\%/%%\\%/%%\\%%\\/");
            sb.AppendLine("%%%%/%%%%%%/%%\\%%/%%%%%%%%\\/%%\\%/%%\\%%/%");
            sb.AppendLine("%%%/%%%%%%%/%%\\%%/%%/\\%%%%/%%%%\\%%%%\\/%%");
            sb.AppendLine("lc/%%%%%%%/%%%%\\/%%/%%\\%%%/%%%%\\%%%%\\/%%");
            sb.AppendLine("\"\"/%%%%%%/%%%%%%,%%/%%\\%%/%%%%%%\\%%%/%%%");
            sb.AppendLine(" /%%%%%%%/%%%%%,~,/%%%%\\/%%%%%%%%\\%/%%%%");
            sb.AppendLine(" /%%%%%%/%%%%%,~~~,%%%%\\/%%%%%%%%\\%/%%%%");
            sb.AppendLine("/%%%%%#%/#%%%,~~~~~,%%%/%%%%%%%%%%/%%%%%");
            sb.AppendLine("\"\"\"\"\"\"\"\\/\"\"\",~~~~~~~,\"\"/%%%%%%%%%/%%%%%%");
            sb.AppendLine(" -_          ,~~;~~,   \"\"\"\"\"\"\"\"\"\"/%%%%%%");
            sb.AppendLine("      ^^        |   ,    _-     /%%%%%%%");
            sb.AppendLine("            _-    ,`|`,         \"\"\"\"\"\"\"\"");
            sb.AppendLine("  _-               \\ /           _-    ");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");

            Console.WriteLine(sb.ToString());
        }
        public void Dessin3()
        {
            Console.Clear();
            Console.WriteLine("                                               _\r\n                 ___                          (_)\r\n               _/XXX\\\r\n_             /XXXXXX\\_                                    __\r\nX\\__    __   /X XXXX XX\\                          _       /XX\\__      ___\r\n    \\__/  \\_/__       \\ \\                       _/X\\__   /XX XXX\\____/XXX\\\r\n  \\  ___   \\/  \\_      \\ \\               __   _/      \\_/  _/  -   __  -  \\__/\r\n ___/   \\__/   \\ \\__     \\\\__           /  \\_//  _ _ \\  \\     __  /  \\____//\r\n/  __    \\  /     \\ \\_   _//_\\___     _/    //           \\___/  \\/     __/\r\n__/_______\\________\\__\\_/________\\_ _/_____/_____________/_______\\____/_______\r\n                                  /|\\\r\n                                 / | \\\r\n                                /  |  \\\r\n                               /   |   \\\r\n                              /    |    \\\r\n                             /     |     \\\r\n                            /      |      \\\r\n                           /       |       \\\r\n                          /        |        \\\r\n                         /         |         \\");
        }

        public void Dessin4()
        {
            Console.Clear();
            Console.WriteLine("                      \\|/\r\n                      -o-                              |\r\n                      /|\\                             ( )_\r\n             |                                       /\\ | |\r\n            (_)             |      |   __         |  ||-| |-[]|  \\|/  \\|\r\n ___|___   _| |____   |    (_)_  _( )_|[]|     __(_)_|| |     |_~(|)~~(|\r\n(_)__)__|_| []|[]  |_(_)_  |[]|_|_[]__|__|  __| |[]|__| | []|___|_|____|\r\n| |__| [] |   |[]  |  | |  |    | []  |  | |  | |   |||_|    [][]      |");
        }
        public void Dessin5()
        {

            Console.Clear();
            Console.WriteLine("                      \\|/\r\n                      -o-                              |\r\n                      /|\\                             ( )_\r\n             |                                       /\\ | |\r\n            (_)             |      |   __         |  ||-| |-[]|  \\|/  \\|\r\n ___|___   _| |____   |    (_)_  _( )_|[]|     __(_)_|| |     |_~(|)~~(|\r\n(_)__)__|_| []|[]  |_(_)_  |[]|_|_[]__|__|  __| |[]|__| | []|___|_|____|\r\n| |__| [] |   |[]  |  | |  |    | []  |  | |  | |   |||_|    [][]      |");
        }
        public void Dessin6()
        {
            Console.Clear();
            Console.WriteLine("                                               /\\      /\\\r\n                                               ||______||\r\n                                               || ^  ^ ||\r\n                                               \\| |  | |/\r\n                                                |______|\r\n              __                                |  __  |\r\n             /  \\       ________________________|_/  \\_|__\r\n            / ^^ \\     /=========================/ ^^ \\===|\r\n           /  []  \\   /=========================/  []  \\==|\r\n          /________\\ /=========================/________\\=|\r\n       *  |        |/==========================|        |=|\r\n      *** | ^^  ^^ |---------------------------| ^^  ^^ |--\r\n     *****| []  [] |           _____           | []  [] | |\r\n    *******        |          /_____\\          |      * | |\r\n   *********^^  ^^ |  ^^  ^^  |  |  |  ^^  ^^  |     ***| |\r\n  ***********]  [] |  []  []  |  |  |  []  []  | ===***** |\r\n *************     |         @|__|__|@         |/ |*******|\r\n***************   ***********--=====--**********| *********\r\n***************___*********** |=====| **********|***********\r\n *************     ********* /=======\\ ******** | *********");
        }
        public void Dessin7()
        {
            Console.Clear();
            Console.WriteLine("                                               /\\      /\\\r\n                                               ||______||\r\n                                               || ^  ^ ||\r\n                                               \\| |  | |/\r\n                                                |______|\r\n              __                                |  __  |\r\n             /  \\       ________________________|_/  \\_|__\r\n            / ^^ \\     /=========================/ ^^ \\===|\r\n           /  []  \\   /=========================/  []  \\==|\r\n          /________\\ /=========================/________\\=|\r\n       *  |        |/==========================|        |=|\r\n      *** | ^^  ^^ |---------------------------| ^^  ^^ |--\r\n     *****| []  [] |           _____           | []  [] | |\r\n    *******        |          /_____\\          |      * | |\r\n   *********^^  ^^ |  ^^  ^^  |  |  |  ^^  ^^  |     ***| |\r\n  ***********]  [] |  []  []  |  |  |  []  []  | ===***** |\r\n *************     |         @|__|__|@         |/ |*******|\r\n***************   ***********--=====--**********| *********\r\n***************___*********** |=====| **********|***********\r\n *************     ********* /=======\\ ******** | *********");
        }
        public void Dessin8()
        {
            Console.Clear();
            Console.WriteLine("                                               /\\      /\\\r\n                                               ||______||\r\n                                               || ^  ^ ||\r\n                                               \\| |  | |/\r\n                                                |______|\r\n              __                                |  __  |\r\n             /  \\       ________________________|_/  \\_|__\r\n            / ^^ \\     /=========================/ ^^ \\===|\r\n           /  []  \\   /=========================/  []  \\==|\r\n          /________\\ /=========================/________\\=|\r\n       *  |        |/==========================|        |=|\r\n      *** | ^^  ^^ |---------------------------| ^^  ^^ |--\r\n     *****| []  [] |           _____           | []  [] | |\r\n    *******        |          /_____\\          |      * | |\r\n   *********^^  ^^ |  ^^  ^^  |  |  |  ^^  ^^  |     ***| |\r\n  ***********]  [] |  []  []  |  |  |  []  []  | ===***** |\r\n *************     |         @|__|__|@         |/ |*******|\r\n***************   ***********--=====--**********| *********\r\n***************___*********** |=====| **********|***********\r\n *************     ********* /=======\\ ******** | *********");
        }
        public void Dessin9()
        {
            Console.Clear();
            Console.WriteLine("                                               /\\      /\\\r\n                                               ||______||\r\n                                               || ^  ^ ||\r\n                                               \\| |  | |/\r\n                                                |______|\r\n              __                                |  __  |\r\n             /  \\       ________________________|_/  \\_|__\r\n            / ^^ \\     /=========================/ ^^ \\===|\r\n           /  []  \\   /=========================/  []  \\==|\r\n          /________\\ /=========================/________\\=|\r\n       *  |        |/==========================|        |=|\r\n      *** | ^^  ^^ |---------------------------| ^^  ^^ |--\r\n     *****| []  [] |           _____           | []  [] | |\r\n    *******        |          /_____\\          |      * | |\r\n   *********^^  ^^ |  ^^  ^^  |  |  |  ^^  ^^  |     ***| |\r\n  ***********]  [] |  []  []  |  |  |  []  []  | ===***** |\r\n *************     |         @|__|__|@         |/ |*******|\r\n***************   ***********--=====--**********| *********\r\n***************___*********** |=====| **********|***********\r\n *************     ********* /=======\\ ******** | *********");
        }

        public void Dessin10()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");

            Console.WriteLine(sb.ToString());
        }
        public void Dessin11()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");

            Console.WriteLine(sb.ToString());
        }
        public void Dessin12()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");

            Console.WriteLine(sb.ToString());
        }
        public void Dessin13()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");

            Console.WriteLine(sb.ToString());
        }
        public void Dessin14()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");

            Console.WriteLine(sb.ToString());
        }
        public void Dessin15()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");

            Console.WriteLine(sb.ToString());
        }
    }
}
