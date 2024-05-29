using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Dessins
{
    internal class Pnj
    {

        public void Dessinpnj(string nom)

        {
            if (nom == "choixperso")
                {
                    StringBuilder sb = new StringBuilder();

                    sb.AppendLine("             ..-.--..                         ,,,_");
                    sb.AppendLine("           ,','.-`.-.`.                      /· ·. `.");
                    sb.AppendLine("          :.',;'     `.\\.                  │ - - '  )");
                    sb.AppendLine("          ||//----,-.--\\|                  /  (  |  )");
                    sb.AppendLine("        \\`:|/-----`-'--||'/               ( `(-)´   )─.");
                    sb.AppendLine("         \\|:    |:'                       (       `)   \\");
                    sb.AppendLine("          `||      \\   |!                /( `     /     \\");
                    sb.AppendLine("          |!|          ;|                │  (    `)  ┬    )");
                    sb.AppendLine("          !||:.   --  /|!                │  /\\   /   │    │");
                    sb.AppendLine("         /||!||:.___.|!||\\              \\_│ .`-´│.  │\\___/");
                    sb.AppendLine("        /|!|||!|    |!||!\\:.            │ │ .│  │.  │/   │");
                    sb.AppendLine("     ,'//!||!||!`._.||!||,:\\\\\\        ├ │ .│__│.  /│  .┤");
                    sb.AppendLine("    : :: |!|||!| SSt|!||! |!::           │ │─_│▄▄│_-´ │   │");
                    sb.AppendLine("    | |! !||!|||`---!|!|| ||!|           │ │          /   │");
                    sb.AppendLine("    | || |!|||!|    |!||! |!||           ( │  '──,   (_,  )");
                    sb.AppendLine("");
                    sb.AppendLine("");

                    Console.WriteLine(sb.ToString());
                }

            if (nom == "soldat")
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine("                 _,..---''-.,");
                sb.AppendLine("              ,-`,-.         `,");
                sb.AppendLine("             /  / _/           \\");
                sb.AppendLine("            /___//_____,--.     ,");
                sb.AppendLine("           /     __,..--'||     |");
                sb.AppendLine("           `T`7 //,-',  //      |");
                sb.AppendLine("            )/_//  `'  //       |");
                sb.AppendLine("            |`-`      <<,       /");
                sb.AppendLine("            \\ _        `,\\     /");
                sb.AppendLine("             |)`',       \\___/");
                sb.AppendLine("             \\`~~       , `--'");
                sb.AppendLine("              |     ,.-'     |");
                sb.AppendLine("               `--,`         \\  _");
                sb.AppendLine("           ,-'`)T(            >` `--..,");
                sb.AppendLine("        ,'`   //\\_\\        ,/`         `-,");
                sb.AppendLine("       (  ___/   /`-....--<               `,");
                sb.AppendLine("        /`  /\\__/\\__,/     >._              )");
                sb.AppendLine("       /   |__/\\__/  \\____/\\  `-,-.____,.--'\\");
                sb.AppendLine("");
                sb.AppendLine("");
                sb.AppendLine("");
                sb.AppendLine("");


                Console.WriteLine(sb.ToString());
            }
            if (nom == "squelette")
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine("                              _.--\"\"-._");
                sb.AppendLine("  .                         .\"         \".");
                sb.AppendLine(" / \\    ,^.         /(     Y             |      )\\");
                sb.AppendLine("/   `---. |--'\\    (  \\__..'--   -   -- -'\"\"-.-'  )");
                sb.AppendLine("|        :|    `>   '.     l_..-------.._l      .'");
                sb.AppendLine("|      __l;__ .'      \"-.__.||_.-'v'-._||`\"----\"");
                sb.AppendLine(" \\  .-'  | |  `              l._       _.'");
                sb.AppendLine("  \\/     | |                   l`^^'^^'j");
                sb.AppendLine("         | |                _   \\_____/");
                sb.AppendLine("         j |               l `--__)-'(__.--' |");
                sb.AppendLine("         | |               | /`---``-----'\"1 |  ,-----.");
                sb.AppendLine("         | |               )/  `--' '---'   \'-'  ___  `-.");
                sb.AppendLine("         | |              //  `-'  '`----'  /  ,-'   I`.  \\");
                sb.AppendLine("       _ L |_            //  `-.-.'`-----' /  /  |   |  `. \\");
                sb.AppendLine("     '._' / \\         _/(   `/   )- ---' ;  /__.J   L.__.\\ :");
                sb.AppendLine("       `._;/7(-.......'  /        ) (     |  |            | |");
                sb.AppendLine("       `._;l _'--------_/        )-'/     :  |___.    _._./ ;");
                sb.AppendLine("         | |                 .__ )-'\\  __  \\  \\  I   1   / /");
                sb.AppendLine("         `-'                /   `-\\-(-'   \\ \\  `.|   | ,' /");
                sb.AppendLine("                           \\__  `-'    __/  `-. `---'',-'");
                sb.AppendLine("                              )-._.-- (        `-----'");
                sb.AppendLine("                              )(  l\\ o ('..-.");
                sb.AppendLine("");
                sb.AppendLine("");

                Console.WriteLine(sb.ToString());
            }
            if (nom == "orc")
            {
                StringBuilder sb = new StringBuilder();


                sb.AppendLine("                        _,.---''```````'-.");
                sb.AppendLine("                    ,-'`                  `-._");
                sb.AppendLine("                 ,-`                   __,-``,\\");
                sb.AppendLine("                /             _       /,'  ,|/ \\");
                sb.AppendLine("              ,'         ,''-<_`'.    |  ,' |   \\");
                sb.AppendLine("             /          / _    `  `.  | / \\ |\\  |");
                sb.AppendLine("             |         (  |`'-,---, `'  \\_|/ |  |");
                sb.AppendLine("             |         |`  \\  \\|  /  __,    _ \\ |");
                sb.AppendLine("             |         |    `._\\,'  '    ,-`_\\ \\|");
                sb.AppendLine("             |         |        ,----      /|   )");
                sb.AppendLine("             \\         \\       / --.      {/   /|");
                sb.AppendLine("              \\         | |       `.\\         / |");
                sb.AppendLine("               \\        / `-.                 | /");
                sb.AppendLine("                `.     |     `-        _,--V`)\\/        _,-");
                sb.AppendLine("                  `,   |           /``V_,.--`  \\.  _,-'`");
                sb.AppendLine("                   /`--'`._        `-'`         )`'");
                sb.AppendLine("                  /        `-.            _,.-'`");
                sb.AppendLine("                              `-.____,.-'`");
                sb.AppendLine("");
                sb.AppendLine("");


                Console.WriteLine(sb.ToString());
            }
            if (nom == "loup")
            {
                StringBuilder sb = new StringBuilder();


                sb.AppendLine("      /^\\      /^\\");
                sb.AppendLine("      |  \\    /  |");
                sb.AppendLine("      ||\\ \\../ /||");
                sb.AppendLine("      )'        `(");
                sb.AppendLine("     ,;`w,    ,w';,");
                sb.AppendLine("     ;,  ) __ (  ,;");
                sb.AppendLine("      ;  \\(\\/)/  ;;");
                sb.AppendLine("     ;|  |vwwv|    ``-...");
                sb.AppendLine("      ;  `lwwl'   ;      ```''-.");
                sb.AppendLine("     ;| ; `\"\"' ; ;              `.");
                sb.AppendLine("      ;         ,   ,          , |");
                sb.AppendLine("      '  ;      ;   l    .     | |");
                sb.AppendLine("      ;    ,  ,    |,-,._|      \\;");
                sb.AppendLine("       ;  ; `' ;   '    \\ `\\     \\;");
                sb.AppendLine("       |  |    |  |     |   |    |;");
                sb.AppendLine("       |  ;    ;  |      \\   \\   (;");
                sb.AppendLine("       | |      | l       | | \\  |");
                sb.AppendLine("       | |      | |       | |  ) |");
                sb.AppendLine("       | |      | ;       | |  | |");
                sb.AppendLine("       ; ,      : ,      ,_.'  | |");
                sb.AppendLine("      :__'      | |           ,_.'");
                sb.AppendLine("               `--'");
                sb.AppendLine("");
                sb.AppendLine("");

                Console.WriteLine(sb.ToString());
            }
            if (nom == "dragonnet")
            {
                StringBuilder sb = new StringBuilder();


                sb.AppendLine(" \\----------/(           ___              ###########");
                sb.AppendLine("   \\``````/ |,,\\        / @.\\_       ###################");
                sb.AppendLine("     \\``/,,,|,,,,\\   _ / /____%>**@@######################");
                sb.AppendLine("      \\`____|,,,,,\\/...//          ###################");
                sb.AppendLine("              ~\\, .... /--------/(       ###########");
                sb.AppendLine("              /....____----~~~/,,,,\\");
                sb.AppendLine("    |       /`../~`))  ~-,,,/,,,,,,,,\\");
                sb.AppendLine("    |\\___/``./``         \\/____________\\");
                sb.AppendLine("     \\__ /``");
                sb.AppendLine("");
                sb.AppendLine("");


                Console.WriteLine(sb.ToString());
            }
            if (nom == "potionmaster")
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine("                                       .");
                sb.AppendLine("                             /^\\     .");
                sb.AppendLine("                        /\\   \"V\"");
                sb.AppendLine("                       /__\\   I      O  o");
                sb.AppendLine("                      //..\\  I     .");
                sb.AppendLine("                      \\].`[/  I");
                sb.AppendLine("                      /l\\/j\\  (]    .  O");
                sb.AppendLine("                     /. ~~ ,\\/I          .");
                sb.AppendLine("                     \\\\L__j^\\/I       o");
                sb.AppendLine("                      \\/--v}  I     o   .");
                sb.AppendLine("                      |    |  I   _________");
                sb.AppendLine("                      |    |  I c(`       ')o");
                sb.AppendLine("                      |    l  I   \\.     ,/     ");
                sb.AppendLine("                    _/j  L l\\_!  _//^---^\\\\_");
                sb.AppendLine("                 ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
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
            if (nom == "trou")
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine("                                       ");
                sb.AppendLine("*******************************************");
                sb.AppendLine("******************    *********************");
                sb.AppendLine("*************             *****************");
                sb.AppendLine("*****                              ********");
                sb.AppendLine("****                               ********");
                sb.AppendLine("****                               ********");
                sb.AppendLine("***                                 *******");
                sb.AppendLine("****                               ********");
                sb.AppendLine("*******                        ************");
                sb.AppendLine("*********                     *************");
                sb.AppendLine("**********                  ***************");
                sb.AppendLine("************              *****************");
                sb.AppendLine("*****************    **********************");
                sb.AppendLine("*******************************************");
                sb.AppendLine("");
                sb.AppendLine("");
                sb.AppendLine("");
                sb.AppendLine("");
                sb.AppendLine("");

                Console.WriteLine(sb.ToString());
            }


        }
    }
}
