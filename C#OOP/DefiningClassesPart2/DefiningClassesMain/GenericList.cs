using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesMain
{
    public class GenericList<T>     //Problem 5. Generic class
        where T: IComparable
    {
        public T[] Elements { get; set; }
        public int Index { get; set; }
        public int Capacity { get; private set; }
        
        
        public GenericList( int capacity)
        {
            this.Elements = new T[capacity];
            this.Capacity = capacity;
            this.Index = 0;
        }

        public void AddElement(T element)
        {
            if (this.Index-1 == this.Elements.Length)
            {
                DoubleCapacity();
            }

            this.Elements[Index] = element;
            this.Index++;

        }

        public T GetElement(int position)
        {
                CheckIndex(position);
                return this.Elements[position];
        }

        public void RemoveElement(int position)
        {
            CheckIndex(position);
            for (int i = position; i < this.Elements.Length-1; i++)
            {
                this.Elements[i] = this.Elements[i + 1]; 
            }
            this.Elements[this.Elements.Length - 1] = default(T);
            this.Index--;
        }

        public void InsertElement(T element, int position)
        {
            CheckIndex(position);
            if (this.Index-1 == this.Elements.Length)
            {
                DoubleCapacity();
            }

            for (int i = this.Index-1; i > position; i--)
            {
                this.Elements[i] = this.Elements[i - 1];
            }

            this.Elements[position] = element;
            this.Index++;
            
        }

        private void DoubleCapacity()  //Problem 6. Auto-grow
        {
            T[] buffer = new T[this.Capacity];
            for (int i = 0; i < this.Elements.Length; i++)
            {
                buffer[i] = this.Elements[i];
            }
            this.Capacity = this.Capacity * 2;
            this.Elements = new T[this.Capacity];
            for (int i = 0; i < buffer.Length; i++)
            {
                this.Elements[i] = buffer[i];
            }
        }

        public void Clear()
        {
            for (int i = 0; i < this.Elements.Length; i++)
            {
                this.Elements[i] = default(T); 
            }
        }

        public int FindElement(T value)
        {
            for (int i = 0; i < this.Elements.Length; i++)
            {
                if (this.Elements[i].Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < this.Elements.Length; i++)
            {
               builder.Append(this.Elements[i].ToString()); 
                builder.Append(" ");
            }

            return builder.ToString();
        }

        private void CheckIndex(int index)
        {
            if (index > this.Index - 1 || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
        }

        public T Min()    //Problem 7. Min and Max
        {
            T result = default(T);

            if (this.Index > 0)
            {
                result = this.Elements[0];

                for (int i = 0; i < this.Elements.Length; i++)
                {
                    if (result.CompareTo(this.Elements[i]) > 0)
                    {
                        result = this.Elements[i];
                    }
                }

            }
            return result;
        }
        public T Max()     //Problem 7. Min and Max
        {
            T result = default(T);

            if (this.Index > 0)
            {
                result = this.Elements[0];

                for (int i = 0; i < this.Elements.Length; i++)
                {
                    if (result.CompareTo(this.Elements[i]) < 0)
                    {
                        result = this.Elements[i];
                    }
                }

            }
            return result;
        }
    }
}
