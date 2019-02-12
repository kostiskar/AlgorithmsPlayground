using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLibrary
{
    public class SortingAlgorithmsModel
    {
        // Bubble Sort Implementation
        public static List<int> BubbleSort(List<int> dataList)
        {
            int memoryBox;
            int counter = 0;
            int rounds = dataList.Count;

            // Rounds
            for (int j = 0; j < dataList.Count; j++)
            {
                counter = 0;
                for (int i = 0; i < rounds - 1; i++)
                {
                    if (dataList[i] > dataList[i + 1])
                    {
                        // Bubbling
                        memoryBox = dataList[i + 1];
                        dataList[i + 1] = dataList[i];
                        dataList[i] = memoryBox;
                        counter++;
                    }
                }
                rounds--;

                if (counter == 0)
                    break;
            }

            return dataList;
        }

        // Insertion Sort Implementation
        public static List<int> InsertionSort(List<int> dataList)
        {
            int key;
            int j;

            for (int i = 1; i < dataList.Count; i++)
            {
                key = dataList[i];
                j = i - 1;

                while (j >= 0 && dataList[j] > key)
                {
                    dataList[j + 1] = dataList[j];
                    j--;
                }
                dataList[j + 1] = key;
            }

            return dataList;
        }

        // Selection Sort Implementation
        public static List<int> SelectionSort(List<int> dataList)
        {
            int minVal;
            int j;
            int lastPlace;
            int updatedPlace = 0;
            bool smallerValueFound = false;

            for (int i = 0; i < dataList.Count; i++)
            {
                minVal = dataList[i];
                smallerValueFound = false;
                lastPlace = i;

                for (j = i; j < dataList.Count; j++)
                {
                    if (dataList[j] < minVal)
                    {
                        minVal = dataList[j];
                        updatedPlace = j;
                        smallerValueFound = true;
                    }
                }

                if (smallerValueFound)
                {
                    dataList[updatedPlace] = dataList[i];
                    dataList[i] = minVal;
                }
            }

            return dataList;
        }
    }
}
