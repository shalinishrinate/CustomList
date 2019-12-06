using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomL;

namespace CustomListTest
{
    [TestClass]
    public class CustomListTest
    {

        //Add Test 1: to check when something is added to an empty list, will it go to index 0.

        [TestMethod]
        public void Add_ToAnEmptyList_ItemShouldGoToIndexNumberZero()
        {
            // arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 13;
            int actual;
            int num1 = 13;

            // act
            customList.Add(num1);

            actual = customList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }


        //Add Test 2: to check when 7 values are added to customlist, will the count be 7

        [TestMethod]
        public void Add_ItemsToList_ReturnsCountOfList()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int num1 = 5;
            int num2 = 10;
            int num3 = 15;
            int num4 = 20;
            int num5 = 25;
            int num6 = 30;
            int num7 = 35;
            int expected = 7;
            int actual;

            //act
            customList.Add(num1);
            customList.Add(num2);
            customList.Add(num3);
            customList.Add(num4);
            customList.Add(num5);
            customList.Add(num6);
            customList.Add(num7);
            actual = customList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        //Add Test 3: to check the capacity even when the count is less.

        [TestMethod]
        public void Add_ItemsToList_ReturnsCapacity()
        {
            //arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 8;
            int actual;
            int num1 = 5;
            int num2 = 10;
            int num3 = 15;
            int num4 = 20;
            int num5 = 25;
            int num6 = 30;
            int num7 = 35;

            //act
            customList.Add(num1);
            customList.Add(num2);
            customList.Add(num3);
            customList.Add(num4);
            customList.Add(num5);
            customList.Add(num6);
            customList.Add(num7);

            actual = customList.Capacity;

            //assert
            Assert.AreEqual(expected, actual);
        }

        //Add Test 4: check if new item is added to end
        public void Add_string_ReturnsNewerItemsAddedTotheEnd()
        {
            //arrange
            CustomList<string> customList = new CustomList<string>();
            string expected = "Pewaukee";
            string actual;
            string city1 = "Milwaukee";
            string city2 = "Waukesha";
            string city3 = "Brookfield";
            string city4 = "Pewaukee";

            //act

            customList.Add(city1);
            customList.Add(city2);
            customList.Add(city3);
            customList.Add(city4);


            actual = customList[3];

            //assert
            Assert.AreEqual(expected, actual);
        }

        //Add Test 5: to check when items are added to a full array , will the newer items be still added.

        [TestMethod]
        public void Add_ToFullArray_WillStillBeAdded()
        {
            // arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 35;
            int actual;
            int num1 = 5;
            int num2 = 10;
            int num3 = 15;
            int num4 = 20;
            int num5 = 25;
            int num6 = 30;
            int num7 = 35;

            // act
            customList.Add(num1);
            customList.Add(num2);
            customList.Add(num3);
            customList.Add(num4);
            customList.Add(num5);
            customList.Add(num6);
            customList.Add(num7);
            actual = customList[6];

            // assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Add_To1FullArray_WillStillBeAdded()
        {
            // arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 8;
            int actual;
            int num1 = 5;
            int num2 = 10;
            int num3 = 15;
            int num4 = 20;
            int num5 = 25;
            int num6 = 30;
            int num7 = 35;

            // act
            customList.Add(num1);
            customList.Add(num2);
            customList.Add(num3);
            customList.Add(num4);
            customList.Add(num5);
            customList.Add(num6);
            customList.Add(num7);
            actual = customList.Capacity;

            // assert
            Assert.AreEqual(expected, actual);
        }


    }
}

