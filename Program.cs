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
           for(int i = 0; i < 9;i++)
           {
                Console.Write("\nEnter number: ");
                num = Console.ReadKey().KeyChar;
                Console.Write($"\nResult: {numToLine.reversNumToLine(num)}");
           }
                


           


            Console.ReadKey();

        }
    }
}
