using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace List_Arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Arraylist = new ArrayList();
            List<int> List = new List<int>();
            
           
            Console.WriteLine("Your enter");
            int count=int.Parse(Console.ReadLine());
            ListOrArraylist(Arraylist, List, count);
           
                Console.WriteLine("list {0}", List.Count);
          
            Console.WriteLine("Arraylist count {0}",Arraylist.Count);
            Console.ReadKey();
        }

     
        static void ListOrArraylist(ArrayList arraylist, List<int> list, int count) 
        {
          Random ran = new Random();
          
          for (int i = 0; i < count; i++)
          {
              int j = ran.Next(1, 100);   
                  arraylist.Add(j);
                  list.Add(j);
          }
           
       
        }
    }
}
