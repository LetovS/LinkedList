using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Codeblog
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new Model.LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Print(list);

            list.Add(4);
            list.Add(5);
            list.Add(6);
            //list.Delete(4);
            Print(list);
            list.Delete(7);
            list.Appende(99);
            Print(list);
            list.Insert(4, 66);
            Print(list);
        }

        private static void Print(Model.LinkedList<int> list)
        {
            foreach (var item in list)
            {
                Console.Write($"Data = {item} ");
            }
            Console.WriteLine();
        }
    }
}
