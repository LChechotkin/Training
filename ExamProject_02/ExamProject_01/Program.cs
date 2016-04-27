using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ExamProject
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> MyListInt = new LinkedList<int>(10);

            //for (int i = 1; i < 1; i++)
            //{
            //    MyListInt.AddFirst(3-i);
            //    MyListInt.AddFirst(i-4);
            //    MyListInt.AddLast(3 - i);
            //    MyListInt.AddLast(i-4);

            //}
            MyListInt.AddFirst(3 );
            MyListInt.Print();

            MyListInt.Remove(0);

            MyListInt.RemoveFirst();
            MyListInt.RemoveLast();

            MyListInt.Find(2);
            MyListInt.Print();


            if (MyListInt.First() == MyListInt.Last()) Console.WriteLine("Comparable!!!!!");
            if (MyListInt.First() != MyListInt.Last()) Console.WriteLine("Comparable!!!!!");


            Console.ReadKey();
            

        }
    }
}
