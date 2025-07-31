using System.Collections;

namespace Assignment02ADV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            //string[] input = Console.ReadLine().Split();
            //int n = int.Parse(input[0]);
            //int q = int.Parse(input[1]);

            //int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            //for (int i = 0; i < q; i++)
            //{
            //    int x = int.Parse(Console.ReadLine());
            //    int count = 0;

            //    foreach (int num in arr)
            //    {
            //        if (num > x)
            //            count++;
            //    }
            //    Console.WriteLine($"count :{count}");

            //}
            #endregion

            #region Q2

            //int n = int.Parse(Console.ReadLine());
            //int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //bool isPalindrome = true;

            //for (int i = 0; i < n / 2; i++)
            //{
            //    if (arr[i] != arr[n - i - 1])
            //    {
            //        isPalindrome = false;
            //        break;
            //    }
            //}

            //Console.WriteLine(isPalindrome ? "YES" : "NO");

            #endregion

            #region Q3

            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);

            //Stack<int> stack = new Stack<int>();
            //while (queue.Count > 0)
            //    stack.Push(queue.Dequeue());

            //while (stack.Count > 0)
            //    queue.Enqueue(stack.Pop());

            //foreach (var item in queue)
            //    Console.Write(item + " ");
            #endregion


            #region Q4
            //string input = Console.ReadLine();
            //Stack<char> stack = new Stack<char>();

            //bool balanced = true;
            //foreach (char c in input)
            //{
            //    if ("({[".Contains(c))
            //        stack.Push(c);
            //    else if (")}]".Contains(c))
            //    {
            //        if (stack.Count == 0 ||
            //            (c == ')' && stack.Pop() != '(') ||
            //            (c == ']' && stack.Pop() != '[') ||
            //            (c == '}' && stack.Pop() != '{'))
            //        {
            //            balanced = false;
            //            break;
            //        }
            //    }
            //}

            //Console.WriteLine(balanced && stack.Count == 0 ? "Balanced" : "Not Balanced");


            #endregion


            #region Q5
            //int[] array = { 1, 3, 5, 3, 7, 1, 9, 5 };
            //int[] noDuplicates = RemoveDuplicates(array);

            //Console.WriteLine("Array after removing duplicates:");
            //foreach (int num in noDuplicates)
            //{
            //    Console.Write(num + " ");
            //}
            #endregion

            #region Q6
            //ArrayList list = new ArrayList() { 1, 2, 3, 4, 5, 6 };
            //for (int i = list.Count - 1; i >= 0; i--)
            //{
            //    if ((int)list[i] % 2 != 0)
            //        list.RemoveAt(i);
            //}

            //foreach (var item in list)
            //    Console.Write(item + " ");
            #endregion

            #region Q7
            //Queue queue = new Queue();
            //queue.Enqueue(1);
            //queue.Enqueue("Apple");
            //queue.Enqueue(5.28);

            //foreach (var item in queue)
            //    Console.WriteLine(item);
            #endregion

            #region Q8
            //    Stack<int> myStack = new Stack<int>();

            //    // Push sample integers onto the stack
            //    myStack.Push(10);
            //    myStack.Push(20);
            //    myStack.Push(30);
            //    myStack.Push(40);
            //    myStack.Push(50);

            //    Console.Write("Enter the target number to search: ");
            //    int target;

            //    // Validate user input
            //    if (int.TryParse(Console.ReadLine(), out target))
            //    {
            //        Helper.SearchInStack(myStack, target);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input. Please enter an integer.");
            //    }
            //}
            #endregion

            #region Q9
            int[] arr1 = { 1, 2, 3, 4, 4 };
            int[] arr2 = { 10, 4, 4 };

            Dictionary<int, int> freq = new Dictionary<int, int>();
            foreach (int num in arr1)
            {
                if (!freq.ContainsKey(num))
                    freq[num] = 0;
                freq[num]++;
            }

            List<int> result = new List<int>();
            foreach (int num in arr2)
            {
                if (freq.ContainsKey(num) && freq[num] > 0)
                {
                    result.Add(num);
                    freq[num]--;
                }
            }

            Console.WriteLine("[" + string.Join(",", result) + "]");
        }
        #endregion

        #region Q10
        //        List<int> list = new List<int> { 1, 2, 3, 7, 5 };
        //        int target = 12;

        //        for (int start = 0; start<list.Count; start++)
        //        {
        //            int sum = 0;
        //        List<int> sub = new List<int>();
        //            for (int end = start; end<list.Count; end++)
        //            {
        //                sum += list[end];
        //                sub.Add(list[end]);

        //                if (sum == target)
        //                {
        //                    Console.WriteLine("[" + string.Join(", ", sub) + "]");
        //                    return;
        //                }
        //}
        //        }

        //        Console.WriteLine("No subarray found");

        #endregion

        #region Q11
        Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5 });
        int k = 3;

        Stack<int> stack = new Stack<int>();
        for (int i = 0; i<k; i++)
            stack.Push(queue.Dequeue());

        Queue<int> result = new Queue<int>();
        while (stack.Count > 0)
            result.Enqueue(stack.Pop());

        while (queue.Count > 0)
            result.Enqueue(queue.Dequeue());

        Console.WriteLine("[" + string.Join(", ", result) + "]");
        #endregion



}

   
    }


    }


