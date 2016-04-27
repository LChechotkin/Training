using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject
{
    class LinkedList<T> : ILinkedList<T>,IEnumerable<T>, IEnumerator<T>, IPrintable where T : IComparable<T>

    {


        
        int length=0;
        private Node<T> LastValue = null;
        private Node<T> FirstValue = null;
       
        int enumIndex = -1;
        private Node<T> enumTmpList = null;


        //public LinkedList()
        //{
        //    LastValue = null;
        //    FirstValue = null;

        //}

     public LinkedList(T value)
        {
            Node<T> Tmp = new Node<T>();
            Tmp.Value = value;
            Tmp.Prev = null;
            Tmp.Next = null;
            
         LastValue= FirstValue = Tmp;
         
         length++;
        }


        public void AddFirst(T value)
        {
            Node<T> Tmp = new Node<T>();
            Tmp.Value = value;
            Tmp.Prev = null;
            
            if (FirstValue == LastValue) 
                LastValue.Prev = Tmp;
            else 
                FirstValue.Prev = Tmp;
            

            Tmp.Next = this.FirstValue;

            this.FirstValue = Tmp;
            length++;
        }

        public void AddLast(T value)
        {
            Node<T> Tmp = new Node<T>();
            Tmp.Value = value;
            Tmp.Next = null;
            

            if (FirstValue == LastValue)
                FirstValue.Next = Tmp;
            else 
                LastValue.Next = Tmp;
            
            Tmp.Prev = LastValue;

            this.LastValue = Tmp;

            length++;
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
                    {
                        FirstValue = LastValue = null;
                        length--;
                    }
                    else if (pointer == FirstValue)                         //if need to delete first element 
                    {
                        this.RemoveFirst();
                  
                    }
                    else if (pointer == LastValue)                          //if need to delete last element 
                    {
                        this.RemoveLast();

                    }
                    else
                    {
                        pointer.Next.Prev = pointer.Prev;
                        pointer.Prev.Next = pointer.Next;
                        length--;
                    }

                }
              

                //Console.ReadKey();
                pointer = pointer.Next;
            }

        

        }

        public void RemoveFirst()
        {

            if (FirstValue == LastValue)

                FirstValue = LastValue = null;
            else
            {
                FirstValue.Next.Prev = null;
                FirstValue = FirstValue.Next;
            }

            length--;
        }

        public void RemoveLast()
        {
            if (FirstValue == LastValue)

                FirstValue = LastValue = null;
            else
            {
                LastValue.Prev.Next = null;
                LastValue = LastValue.Prev;
                
            }

            length--;
        }

        public bool Find(T value)
        {
            Node<T> pointer = FirstValue;
            while (pointer != null)
            {
           
                if (pointer.Value.Equals(value))
                {

                    Console.WriteLine("Value was found: {0}", pointer.Value);
                    return true;
                }

                pointer = pointer.Next;
            }
            return false;
        }

        public int Lenght()
        {
            return length;
            
        }

        public Node<T> First() // Public or Private???
        {
        
        return FirstValue;
        }


        public Node<T> Last()  // Public or Private???
        {
        return LastValue;
        }



        public void Print()
        {
            Node<T> pointer = FirstValue;
            
            Console.WriteLine("**********Start********");

            while (pointer != null)
            {                
                Console.WriteLine("{0}", pointer.Value);
                //Console.ReadKey();
                pointer = pointer.Next;
            }

            Console.WriteLine("Length = {0}", length);
            Console.WriteLine("------------End---------");
        }



       public int CompareTo(Node<T> other)
        {
            return 1;//this.Value.CompareTo(other.Value);
        }


       public void Sort()
       {
           if (this.length < 2) { Console.WriteLine("Sorting is not required: One or Zero elements"); return; }

           Node<T> pointer = FirstValue;

           while (pointer.Next != null)
           {
               Console.WriteLine("{0}", pointer.Value);
               //Console.ReadKey();
               pointer = pointer.Next;

           }

           Console.WriteLine("Length = {0}", length);
        
       }

       public IEnumerator<T> GetEnumerator()
       {
           Node<T> pointer = FirstValue;
           while (pointer != null)
           {
               yield return pointer.Value;
               pointer = pointer.Next;
           }
       }




       System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
       {
           return ((IEnumerable<T>)this).GetEnumerator();

       }






       //public T Current
       //{
         
       //}



public void Dispose()
{
    throw new NotImplementedException();
}

object System.Collections.IEnumerator.Current
{
    get
    {

        if (this.enumIndex == -1)
        {

            Console.WriteLine("Error: positiona is not defined");
            
            return null;

        }

        return enumTmpList.Value;

    }
}

public bool MoveNext()
{
    if (length > 0)
    {

        if (enumTmpList.Next != null)
        {

            enumTmpList = enumTmpList.Next;
            return true;
        }
        else return false;
    }

    return false;

}

public void Reset()
{
    throw new NotImplementedException();
    this.enumIndex = -1;

}







T IEnumerator<T>.Current
{
    get { throw new NotImplementedException(); }
}
    }
}
