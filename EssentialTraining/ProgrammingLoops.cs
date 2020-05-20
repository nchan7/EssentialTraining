using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialTraining
{    
    public class ProgrammingLoops
    {
        public string BreakAndContinue()
        {
            var sb = new StringBuilder();
            var words = new List<string>() { "Bread", "Milk", "Eggs", "Cheese", "Apples" };
            foreach (var word in words)
            {
                if (word.StartsWith("M")) continue;

                if (word.StartsWith("C")) break;

                sb.AppendLine(word);
            }
            return sb.ToString();
        }
        public int DoWhileLoop()
        {
            var sum = 0;
            var counter = 0;
            do
            {
                sum += counter;
                counter++;
            } while (counter < 100);

            return sum; 
        }
        public int WhileLoop()
        {
            var sum = 0;
            var counter = 0;
            while(counter < 100)
            {
                sum += counter;
                counter++;
            }
            return sum;
        }
        public int ForEachLoop()
        {
            var numbers = new List<int>() { 1, 3, 5, 7, 9 };
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }
        public int ForLoop()
        {
            var sum = 0;
            for(var i = 0; i < 100; i++)
            {
                sum = sum + i;
            }
            return sum; 
        }
    }
}
