using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeweySystem.ReplaceBooks
{
    //bubble sort algorithm
    public class Sort
    {
        public List<string> performBubbleSort(List<string> list)
        {
            string temp;

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - 1; j++)
                {
                    if (list[j].CompareTo(list[j + 1]) > 0)
                    {
                        temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }

            return list;
        }
    }
}
