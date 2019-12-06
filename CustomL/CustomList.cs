using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomL
{
    public class CustomList<T>
    {
        // member variables
        private T[] items;
        private int count; //cause it is a number I am looking for
        private int capacity;// same as above


        //constructor
        public CustomList()
        {
            capacity = 4;
            count = 0;
            items = new T[capacity];
        }


        //methods
        public T this[int i]
        {
            get
            {
                return items[i];
            }
            set
            {
                items[i] = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }

        }

        public int Capacity
        {
            get
            {
                return capacity;
            }

        }

        public void Add(T item)
        {
            if (count == capacity)
            {
                capacity *= 2; //count reaches capacity// 
            }


            T[] tempArray = new T[capacity]; // need to make this items already in the smaller array not need to be transferre to a new array

            for (int i = 0; i < count; i++) // items need to transferred to the new array
            {
                tempArray[i] = items[i];
            }
            //tempArray[count] = item; // item here is equal to capacity  
            items = new T[capacity];
            for (int i = 0; i < count; i++) // items need to transferred to the new array
            {
                items[i] = tempArray[i];
            }

            items[count] = item;
            count++;


        }
   
    }
}

