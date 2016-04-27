using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject_01
{
    class LinkedList<T> : ILinkedList<T>, IPrintable
    {

        private T Value;
        private LinkedList<T> FirstValue = null;
        private LinkedList<T> LastValue = null;
        private LinkedList<T> Prev = null;
        private LinkedList<T> Next = null;
        // private LinkedList<T> Tmp = null;

        public LinkedList()
        {
            //this.Value = value;
            //this.Next = null;
            //this.Prev = null;
            //FirstValue = this;
            //LastValue = this;

        }




        public LinkedList(T value)
        {
            this.Value = value;
            this.Next = null;
            this.Prev = null;

            FirstValue = this;
            LastValue = this;

        }


        public void AddFirst(T value)
        {
            LinkedList<T> Tmp = new LinkedList<T>();
            Tmp.Value = value;
            Tmp.Prev = null;
            if (this.LastValue == null)   //if it will be the first element in the list
            {

                Tmp.Next = null;
                this.LastValue = Tmp;
            }
            else
            {
                if (FirstValue == LastValue) LastValue.Prev = Tmp;
                Tmp.Next = this.FirstValue;

            }

            this.FirstValue = Tmp;


        }

        public void AddLast(T value)
        {
            LinkedList<T> Tmp = new LinkedList<T>();

            Tmp.Value = value;
            Tmp.Next = null;

            if (this.FirstValue == null)   //if it will be the first element in the list
            {

                Tmp.Prev = null;
                this.FirstValue = Tmp;

            }
            else
            {
                if (FirstValue == LastValue) FirstValue.Next = Tmp;


                Tmp.Prev = this.LastValue;
            }


            this.LastValue = Tmp;

        }


        public void Remove(T value)
        {

            Node<T> pointer = FirstValue;


            while (pointer != null)
            {

                if (pointer.Value.Equals(value))
                {
                    Console.WriteLine("Looking value found: {0}", pointer.Value);


                    if (FirstValue == LastValue)                            //if only single elment in LinkedList

                        FirstValue = LastValue = null;

                    else if (pointer == FirstValue)                         //if need to delete first element 
                    {
                        pointer.Next.Prev = null;
                        FirstValue = pointer.Next;
                    }
                    else if (pointer == LastValue)                          //if need to delete last element 
                    {
                        pointer.Prev.Next = null;
                        LastValue = pointer;

                    }
                    else
                    {
                        pointer.Next.Prev = pointer.Prev;
                        pointer.Prev.Next = pointer.Next;
                    }

                }
            }
        }
        public void RemoveFirst()
        {
            throw new NotImplementedException();
        }

        public void RemoveLast()
        {
            throw new NotImplementedException();
        }

        public bool Find(T value)
        {
            throw new NotImplementedException();
        }

        public int Lenght()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            LinkedList<T> pointer = FirstValue;

            while (pointer != null)
            {
                Console.WriteLine("{0}", pointer.Value);
                //Console.ReadKey();
                current = pointer.Next;
            }

       
        }





    }
}
