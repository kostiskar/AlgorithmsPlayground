using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsLibrary;

namespace AlgorithmsApp
{

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithms Implementation Application\n\n");

            #region Variables

            int ListLenght = 100;
            int minVal = 0;
            int maxVal = 55;
            List<int> numberList = new List<int>(ListLenght);

            #endregion

            // Populate List with data
            numberList = GenerateDataModel.InitializeListWithRandomNumbers(numberList, ListLenght, minVal, maxVal);

            // Implement searching & sorting algorithms using the AlgrithmsLibrary

            Console.WriteLine("The list before bubble sort (unsorted version): \n");
            PrintDataModel.PrintList(numberList);
            Console.WriteLine("\n\nThe list after bubble sort (sorted version): \n");
            PrintDataModel.PrintList(SortingAlgorithmsModel.BubbleSort(numberList));
            
            Console.WriteLine("\n\nThe list after insertion sort (sorted version): \n");
            PrintDataModel.PrintList(SortingAlgorithmsModel.InsertionSort(numberList));

            Console.WriteLine("\n\nThe list after selection sort (sorted version): \n");
            PrintDataModel.PrintList(SortingAlgorithmsModel.SelectionSort(numberList));

            SearchingAlgorithmsModel.LinearSearch(numberList, 9);

            SearchingAlgorithmsModel.BinarySearch(numberList, 0);


            // Wait for user's keystroke to terminate
            Console.ReadLine();
        }
    }
}
