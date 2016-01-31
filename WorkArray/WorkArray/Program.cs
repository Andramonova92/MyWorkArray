using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkArray
{
    class Program
    {
        static void Main(string[] args)
        {
            arrayTable();
        }

        static void arrayTable()
        {
            int[] table = new int[10];
            int number;
            table[0]=1;
            table[1] = 2;
            table[2] = 3;
            table[3] = 4;
            table[4] = 5;
            table[5] = 6;
            table[6] = 7;
            table[7] = 8;
            table[8] = 9;
            table[9] = 10;
            Console.WriteLine("Please enter a number to multiply:");
            number = int.Parse(Console.ReadLine());
            for (int i = 0; i <table.LongLength; i++) {

                int multiply = table[i] * number;
                Console.WriteLine("{0} *{1}={2}", number, table[i], multiply);
                Console.ReadLine();
            }
            Console.ReadLine();
           }
        }
}
 