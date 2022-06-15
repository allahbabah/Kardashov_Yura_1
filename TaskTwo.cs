using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb_proga_
{
    class TaskTwo:TaskOne
    {
        Random random = new Random();
        Dictionary<string, int> people = new Dictionary<string, int>();
        List<int> listMaxMin = new List<int>();

        public void Add(int a)
        { 
            for (int i = 1; i < a; i++)
            {
                people.Add("Student " + i, random.Next(50));
            }
        }

        public void ShowDictionary()
        {
            foreach (var item in people)
            {
                Console.WriteLine(item);
            }
        }

        public void MinMax()
        { 
            int maxValue = 0;
            int minValue = int.MaxValue;
            bool repeat = true;
            foreach (var item in people)
            {
                if (item.Value < minValue)
                {
                    repeat = true;
                    minValue = item.Value;

                }
                else if (item.Value == minValue)
                {
                    repeat = false;
                }
            }
            if (repeat)
            {
                listMaxMin.Add(minValue);
            }
            foreach (var item in people)
            {
                if (item.Value > maxValue)
                {
                    repeat = true;
                    maxValue = item.Value;
                }
                else if(item.Value==maxValue)
                {
                    repeat = false;
                }
            }
            if (repeat)
            {
                listMaxMin.Add(maxValue);
            }
            Console.WriteLine("Min: "+minValue +" Max: "+ maxValue);
            ShowList(listMaxMin);

        }
    }
}
