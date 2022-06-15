using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb_proga_
{
    class TaskOne
    {
        public int CountPairs(List<int> hello)
        {
            int pairs = 0;
            bool[] noPairs = new bool[hello.Count];
            for (int i = 0; i < hello.Count; i++)
            {
                noPairs[i] = true;
            }
            for (int i = 0; i < hello.Count; i++)
            {
                for (int j = i + 1; j < hello.Count; j++)
                {
                    if (hello[i] == hello[j] && noPairs[i] && noPairs[j])
                    {
                        pairs++;
                        noPairs[i] = false;
                        noPairs[j] = false;
                        break;
                    }
                }
            }
            return pairs;
        }

        public List<int> CreateList(int sizeList)
        {
            Random random = new Random();
            List<int> numbers = new List<int>();
            for (int i = 0; i < sizeList; i++)
            {
                numbers.Add(random.Next(10));
            }
            return numbers;
        }

        public void ShowList(List<int> list)
        {
            Console.WriteLine("----------------------------------------");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------------------");
        }
        
    }
}
