using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;

namespace List_Arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = GenerateInts(new List(),10);
            
            a = GenerateInts(new List(), 100);
            a = GenerateInts(new List(), 1000);
            a = GenerateInts(new List(), 10000);
            a = GenerateInts(new List(), 1000000);
            
            var b = GenerateArraylist(new ArrayList(),10);
        }
        

        public static List<int> GenerateInts(List<int> myInts, int count)
        {
            Console.WriteLine("Мы пишем массив из {0} чисел", count)
            var sw = new Startwatch();
            sw.Start();
                for (int i = 0; i < count; i++)
                {
                    myInts.Add(i);
                }
            Console.WriteLine("Время выполнения = {0}", sw.EllapsedTime);
                return myInts;
        }
        
        public static ArrayList GenerateArraylist(ArrayList arraylist, int count) 
       {
               for (int i = 0; i < count; i++)
               {
                   arraylist.Add(i);
               }
               return arraylist;
        }

        
       public static List<int> DeleteInts(List<int> myInts,int del)
       {
           
           myInts.RemoveAt(del);
           return myInts;
       }

       public static ArrayList DeleteArraylist(ArrayList arraylist, int del) 
       {
           
           arraylist.RemoveAt(del);
           return arraylist;
       }
    }
}
