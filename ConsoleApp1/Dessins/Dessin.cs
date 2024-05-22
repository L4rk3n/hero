using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Dessins
{
    public class Dessin
    {
        public void Dessin1()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("   _______  _______  _______ __________________                     _______  _______  _______  _______  _______   ");
            sb.AppendLine("  (  ___  )(  ____\\(  ____ \\__   __/\\__   __/           |\\     /|(  ____ \\(  ____ )(  ___  )(  ____ \\(  ____ \\  ");
            sb.AppendLine("  | (   ) || (    \\/| (    \\1/   ) (      ) (              | )   ( || (    \\/| (    )|| (   ) || (    \\/| (    \\/  ");
            sb.AppendLine("  | (___) || (_____ | |         | |      | |      _____   | (___) || (__    | (____)|| |   | || (__    | (_____   ");
            sb.AppendLine("  |  ___  |(_____  )| |         | |      | |     (_____)  |  ___  ||  __)   |     __)| |   | ||  __)   (_____  )  ");
            sb.AppendLine("  | (   ) |      ) || |         | |      | |              | (   ) || (      | (\\ (   | |   | || (            ) |  ");
            sb.AppendLine("  | )   ( |/\\____) || (____/\\___) (______) (___           | )   ( || (____/\\| ) \\ \\__| (___) || (____/\\/\\____) |  \\");
            sb.AppendLine("  |/     \\|\\_______)(_______/\\_______/\\_______/           |/     \\|(_______/|/   \\__/(_______)(_______/\\_______)  ");

            Console.WriteLine(sb.ToString());

        }
        public void Dessin2() 
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("                              _.--\"\"-._");
            sb.AppendLine("  .                         .\"         \".");
            sb.AppendLine(" / \\    ,^.         /(     Y             |      )\\");
            sb.AppendLine("/   `---. |--'\\    (  \\__..'--   -   -- -'\"\"-.-'  )");
            sb.AppendLine("|        :|    `>   '.     l_..-------.._l      .'");
            sb.AppendLine("|      __l;__ .'      \"-.__.||_.-'v'-._||`\"----\"");
            sb.AppendLine(" \\  .-' | |  `              l._       _.'");
            sb.AppendLine("  \\/    | |                   l`^^'^^'j");
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
    }
}
