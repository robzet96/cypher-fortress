using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cypher
{
    internal class Menu
    {
        public static void menuChoice ()
        {
            char quit = '1';
            while (quit != 'y' & quit != 'Y')
            {
                Console.WriteLine("\tType C to code your message\n\tType D to decode message\n\tType Q to quit");
                char choice = char.Parse(Console.ReadLine());
                string txt = "";
                if (choice == 'C' | choice == 'D')
                {
                    Console.WriteLine("Insert the message");
                    txt = Console.ReadLine();
                }
                switch (choice)
                {
                    case 'C':
                        for (int i = 0; i < txt.Length; i++)
                        {
                            Console.Write(cypher.Code.showCypher(txt)[i]);
                        }
                        break;
                    case 'D':
                        for (int i = 0; i < txt.Length; i++)
                        {
                            Console.Write(cypher.Code.deCypher(txt)[i]);
                        }
                        break;
                    case 'Q':
                        Console.WriteLine("Are you sure? Y/N");
                        quit = char.Parse(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("There is no option like this");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("**************************************");
            }
        }
    }
}
