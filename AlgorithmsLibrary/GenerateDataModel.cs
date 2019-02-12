using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLibrary
{
    // Data generator, acts as a databαse call emulator
    public class GenerateDataModel
    {
        // Populate a List with random numbers
        public static List<int> InitializeListWithRandomNumbers(List<int> dataList, int listlenght, int minVal, int maxVal)
        {
            Random rndNum = new Random();

            for (int i = 0; i < listlenght; i++)
            {
                dataList.Add(rndNum.Next(minVal, maxVal));
            }

            return dataList;
        }
    }
}
