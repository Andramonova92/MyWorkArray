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
            // Объявляем двумерный массив
            int[,] myArr = new int[11, 11];
            //задаем значения первым множителям(строкам)
            myArr.SetValue(1, 0, 1); //первое число значение, второе номер строки, третье номер столбца
            myArr.SetValue(2,1,1);
            myArr.SetValue(3,2,1);
            myArr.SetValue(4,3,1);
            myArr.SetValue(5,4,1);
            myArr.SetValue(6,5,1);
            myArr.SetValue(7,6,1);
            myArr.SetValue(8,7,1);
            myArr.SetValue(9,8,1);
            myArr.SetValue(10,9,1);
            //задаем значение вторым множителям(столбцам)
            myArr.SetValue(1,1,0);//первое число значение, второе номер столбца, третье номер строки
            myArr.SetValue(2,1,1);
            myArr.SetValue(3,1,2);
            myArr.SetValue(4,1,3);
            myArr.SetValue(5,1,4);
            myArr.SetValue(6,1,5);
            myArr.SetValue(7,1,6);
            myArr.SetValue(8,1,7);
            myArr.SetValue(9,1,8);
            myArr.SetValue(10,1,9);
            
            // циклы для выполнения умножения
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    myArr[i, j] = j*i;
                    //ConsoleColor f = new ConsoleColor();
                     //f = ConsoleColor.Blue;
                    if (i == j) Console.ForegroundColor = ConsoleColor.Blue;
                    else Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("{0}\t", myArr[i, j]);//вывод массива
                }
                Console.WriteLine();
            }

            
           
            
            Console.ReadLine();
           }
        }
}
 