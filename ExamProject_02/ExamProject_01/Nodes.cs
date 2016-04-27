using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject_01
{
    class Node<T>
    {
        private T Value;
        private Node<T> Up = null;
        private Node<T> Down = null;
        
        public void AddToUp(T NewValue)
        {
            this.Up = new Node<T>(NewValue);
            this.Up.Down = this;
        }
        public void AddToDown(T NewValue)
        {
            this.Down = new Node<T>(NewValue);
            this.Down.Up = this;
        }
        public T GetValue()
        {
            return this.Value;
        }
        public void SetValue(T NewValue)
        {
            this.Value = NewValue;
        }
        public T[] ToArray()
        {
            T[] ResultMass;
            Node<T> ThisData = this;
            while (ThisData.Up != null) ThisData = ThisData.Up;
            Int32 KolOfEllements = new Int32();
            while (ThisData.Down != null)
            {
                KolOfEllements++;
                ThisData = ThisData.Down;
            }
            ResultMass = new T[KolOfEllements];
            KolOfEllements = new Int32();
            while (ThisData.Up != null) ThisData = ThisData.Up;
            while (ThisData.Down != null)
            {
                ResultMass[KolOfEllements++] = ThisData.GetValue();
                ThisData = ThisData.Down;
            }
            return ResultMass;
        }
        public Int32 GetLength()
        {
            return this.ToArray().Length;
        }
        public Node()
        {
            this.Up = null;
            this.Down = null;
        }
        public Node(T Value)
        {
            this.Value = Value;
            this.Up = null;
            this.Down = null;
        }
    }
}
