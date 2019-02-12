using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLibrary
{
    public class PrintDataModel
    {

        public static void PrintList<T>(List<T> data)
        {
            int counter = 1;
            for (int i = 0; i < data.Count; i++)
            {
                Console.Write(data[i] + " ");

                if (counter == 4)
                {
                    Console.WriteLine();
                    counter = 0;
                }
                counter++;
            }
        }

    }
}
