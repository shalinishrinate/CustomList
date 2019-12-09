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
        private int count;
        private int capacity;


        //constructor
        public CustomList()
        {
            capacity = 4;
            count = 0;
            items = new T[capacity];
        }


        //methods
        public T this[int i] // C# indexer so that one can make the objects in the list accessible via index.
        {
            get
            {
                return items[i];
            }
            set
            {
                items[i] = value; // value is inbuilt keyword, word value references the value that client code is attempting to assign to the property. 
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
                capacity *= 2; //count reaches capacity, then doubling the capacity
            }

            T[] tempArray = new T[capacity]; //creating a new array of size new capacity

            for (int i = 0; i < count; i++) // Loops through the previous, smaller array and adds the items to the new array. 
            {
                tempArray[i] = items[i]; // item from original array is equal to item of new array in the same index
            }

            items = new T[capacity];
            for (int i = 0; i < count; i++) // items need to transferred to the new array
            {
                items[i] = tempArray[i];
            }

            items[count] = item;
            count++;
        }


        public void Remove(T item)
        {
            T[] tempArray = new T[capacity];
          
            bool haveFoundItem = false;
            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(item) || haveFoundItem)
                {
                    if(i == capacity - 1)
                    {
                        // gets the default value for data type "T"
                        T defaultValue = default(T);
                        tempArray[i] = defaultValue;
                    }
                    else
                    {
                        tempArray[i] = items[i + 1];
                    }
                    haveFoundItem = true;
                }
                else if (!items[i].Equals(item))
                {
                    tempArray[i] = items[i];
                    //index++;
                }
            }

            items = tempArray;

            if (haveFoundItem == true)
            {
                count--;
            }
        }
    }

}