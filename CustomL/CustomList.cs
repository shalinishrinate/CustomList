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

        public void Add
        {
            //get
            //{
            //    return capacity;
            //}
            //set
            //{
            //    // move this to Add() method
            //    if ( count == capacity)/*count reaches capacity*/
            //    {
            //        capacity*= 2;// double the , it means same as capacity += capacity;
            //    }

            //}

        }

        




                // constructor

                // member methods
            }
}