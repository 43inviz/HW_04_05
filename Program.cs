using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_03_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InternationalPassport pass = new InternationalPassport();
            //pass.regPass();

            //pass.showPass();

            //Console.ReadKey();

            char num;
            MyNumToLine numToLine = new MyNumToLine();

            Console.WriteLine("Converting numbers (0-9) from character to string\n");

            try
            {
                do
                {

                    Console.WriteLine("\nEnter number: ");
                    num = Console.ReadKey().KeyChar;
                    Console.WriteLine($"\nResult: {numToLine.reversNumToLine(num)}");

                    Console.WriteLine($"\nFor resume press [ENTER]\nFor Quit - press and HOLD[Esc]");
                } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
          
                


           


            Console.ReadKey();

        }
    }
}
