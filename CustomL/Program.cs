using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomL
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomList<int> customList = new CustomList<int>();
            //int num1 = 5;
            //int num2 = 10;
            //int num3 = 15;
            //int num4 = 20;

            ////act
            //customList.Add(num1);
            //customList.Add(num2);
            //customList.Add(num3);
            //customList.Add(num4);
            //customList.Remove(num3);

            //CustomList<int> customList = new CustomList<int>();
            //int num1 = 5;
            //int num2 = 10;
            //int num3 = 15;
            //int num4 = 20;
            //int num5 = 25;
            //int expected = 4;
            //int actual;

            ////act
            //customList.Add(num1);
            //customList.Add(num2);
            //customList.Add(num3);
            //customList.Add(num4);
            //customList.Remove(num5);

            CustomList<string> customList = new CustomList<string>();
            string city1 = "Waukesha";
            string city2 = "Pewaukee";
            string city3 = "New Berlin";
            string city4 = "Brookfield";
            int expected = 4;
            int actual;

            //act
            customList.Add(city1);
            customList.Add(city2);
            customList.Add(city3);
            customList.Add(city4);
            customList.Remove(city4);
            actual = customList.Capacity;
        }
    }
}
