using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02ADV
{
    public class Helper
    {
        static int[] RemoveDuplicates(int[] input)
        {
            HashSet<int> uniqueElements = new HashSet<int>();
            foreach (int item in input)
            {
                uniqueElements.Add(item);
            }
            // Convert HashSet back to array
            int[] result = new int[uniqueElements.Count];
            uniqueElements.CopyTo(result);
            return result;
        }

        public static void SearchInStack(Stack<int> stack, int target)
        {
            int count = 0;
            bool found = false;

            // Create a temporary stack to preserve original stack
            Stack<int> tempStack = new Stack<int>(stack);

            while (tempStack.Count > 0)
            {
                int current = tempStack.Pop();
                count++;

                if (current == target)
                {
                    found = true;
                    break;
                }
            }

            if (found)
                Console.WriteLine($"Target was found successfully and the count = {count}");
            else
                Console.WriteLine("Target was not found");
        }
    }
}