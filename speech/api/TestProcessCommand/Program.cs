using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProcessCommand;

namespace TestProcessCommand
{
    class Program
    {

        static void Main(string[] args)
        {
            StringToCommand pc = new StringToCommand();
            //Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("input: ");
            string input = Console.ReadLine();
            while (input != "exit")
            {
                //foreach (string s in pc.toPinyin(input))
                //{
                //    Console.WriteLine(s);
                //}

                Console.WriteLine(pc.toPinyin(input));
                Console.WriteLine(pc.toPinyinAbbr(input));

                Console.WriteLine(pc.ConvertToCommand(input));

                Console.WriteLine();
                Console.Write("input: ");
                input = Console.ReadLine();
            }
        }
    }
}
