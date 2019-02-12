using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLibrary
{
    public class SearchingAlgorithmsModel
    {
        // Linear Search Implementation
        public static void LinearSearch(List<int> dataList, int quequeRequest)
        {
            #region Variables Decleration

            int counter = 0;
            List<int> positionList = new List<int>();

            #endregion

            for (int i = 0; i < dataList.Count; i++)
            {
                if (quequeRequest.Equals(dataList[i]))
                {
                    counter++;
                    positionList.Add(i);
                }

            }
            if (counter == 0)
            {
                Console.WriteLine($"\n\n{ quequeRequest } didn't found!");
            }
            else if (counter == 1)
            {
                Console.WriteLine($"\n\n{ quequeRequest } found once at place { positionList[0] }.");
            }
            else
            {
                Console.WriteLine($"\n\n{ quequeRequest } found multiple times at positions: ");
                PrintDataModel.PrintList(positionList);
            }
        }


        // Binary Search Implementation
        public static void BinarySearch(List<int> dataList, int numberToBeFound)
        {
            #region Variables Decleration

            List<int> positions = new List<int>();
            int middlepoint;
            bool isFound = false;
            int firstIndex = 0;
            int lastIndex = dataList.Count;

            #endregion

            // The list must be sorted in order to use the algorithm
            dataList = SortingAlgorithmsModel.BubbleSort(dataList);

            Console.WriteLine("\n\nThe list after bubble sort (sorted version): \n");
            PrintDataModel.PrintList(dataList);


            if (dataList.Count % 2 == 0)
            {
                middlepoint = lastIndex / 2;
            }
            else
            {
                middlepoint = (lastIndex + 1) / 2;
            }

            middlepoint = (firstIndex + lastIndex) / 2;

            while ((middlepoint - firstIndex != 0 && lastIndex - middlepoint != 0))
            {
                if (numberToBeFound == dataList[middlepoint])
                {
                    isFound = true;
                    break;
                }
                else if (numberToBeFound > dataList[middlepoint])
                {
                    firstIndex = middlepoint;

                    if ((firstIndex - lastIndex) % 2 == 0)
                    {
                        middlepoint = (firstIndex + lastIndex) / 2;
                    }
                    else
                    {
                        middlepoint = (firstIndex + lastIndex + 1) / 2;
                    }
                }
                else if (numberToBeFound < dataList[middlepoint])
                {
                    lastIndex = middlepoint;

                    if ((firstIndex - lastIndex) % 2 == 0)
                    {
                        middlepoint = (firstIndex + lastIndex) / 2;
                    }
                    else
                    {
                        middlepoint = (firstIndex + lastIndex + 1) / 2;
                    }
                }
            }

            if (isFound)
            {
                Console.WriteLine($"\n{numberToBeFound} found at position {middlepoint}");
            }
            else
            {
                Console.WriteLine($"\n{numberToBeFound} not found.");
            }

        }

    }

}

