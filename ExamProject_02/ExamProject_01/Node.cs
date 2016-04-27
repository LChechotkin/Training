using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject
{
    public class Node <T> //:IComparable//: IEnumerable<T> 

    {
        public T Value;
        public Node<T> Prev;
        public Node<T> Next;


        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
