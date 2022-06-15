using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb_proga_
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskOne taskOne = new TaskOne();
            TaskTwo taskTwo = new TaskTwo();
            TaskThree taskThree = new TaskThree();
          
            List<int> numbers = taskOne.CreateList(10);
            taskOne.ShowList(numbers);
            Console.WriteLine("Pairs: " + taskOne.CountPairs(numbers));

            Console.WriteLine();
            taskTwo.Add(10);
            taskTwo.ShowDictionary();
            taskTwo.MinMax();

            Console.WriteLine();
            numbers = taskThree.NoPairNumb(numbers);
            numbers = taskThree.NoReapeat(numbers);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
