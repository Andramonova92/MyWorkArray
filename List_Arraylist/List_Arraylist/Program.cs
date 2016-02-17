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
            int[] myInts = new int[25];
            ListOrArraylist(Arraylist, List, myInts);
            Console.WriteLine("Your enter");
            Console.ReadLine();
            foreach (int l in List)
                Console.WriteLine("list {0}", l);
            foreach(int a in Arraylist)
            Console.WriteLine("arraylist {0}", a);
            Console.WriteLine("Arraylist count {0}",Arraylist.Count);
            Console.ReadKey();
        }

     
        static void ListOrArraylist(ArrayList arraylist, List<int> list,int[] myints) 
        {
          Random ran = new Random();
          for (int i = 0; i < myints.Length; i++)
          {
              myints[i] = ran.Next(1, 25);
              if (i < 10)
              {

                  list.Add(myints[i]);
              }
          }
              
                  arraylist.AddRange(list);
                  FillArrayList(list,arraylist, myints);
                              
        }
       static void FillArrayList(List<int>list,ArrayList arraylist,int[] myints) 
        {
            Random ran = new Random();

            for (int j = list.Count; j < myints.Length; j++)
            {
                myints[j] = ran.Next(1, 25);
                arraylist.Add(myints[j]);
                
            }

           
        }
    }
}
