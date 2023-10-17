using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Frog_Lake
{
    internal class Lake : IEnumerable<int>
    {
        public List<int> Stones { get; set; }
        public Lake(params int[] stones) {
            Stones = stones.ToList();
        }
        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            return Stones.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return Stones.GetEnumerator();
        }
        public void FindOddNumbers()
        {
            foreach (int StoneNumber in Stones) { 
                if (StoneNumber % 2 == 1) {
                    Console.Write($"{StoneNumber}, ");
                }
            }
        }
        public void FindEvenNumbers()
        {
            List<int> numbers = new List<int>();
            foreach(int StoneNumber in Stones)
            {
                if (StoneNumber % 2 == 0)
                {
                    numbers.Add(StoneNumber);
                }
            }
            numbers.Reverse();
            foreach (int number in numbers)
            {
                if (numbers.Last() == number)
                {
                    Console.WriteLine($"{number}");
                }
                else
                {
                    Console.Write($"{number}, ");
                }
            }
        }
    }
}
