using System;
using Stack.List;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<decimal> Stack = new Stack<decimal>();
            string input = "6 5 2 1 * - + 5 6 7 - - - 8 /";


            string[] items = input.Split(' ');
            for (int i = 0; i < items.Length; i++)
            {
                if(decimal.TryParse(items[i],out decimal result))
                {
                    Stack.Push(result);
                }
                else
                {
                    decimal result1 = Stack.Pop();
                    decimal result2 = Stack.Pop();
                    decimal numberToAddToTheStack = 0;
                    if (items[i] == "*")
                    {
                        numberToAddToTheStack = result1 * result2;
                    }
                    else if (items[i] == "/")
                    {
                        numberToAddToTheStack = result1 / result2;
                    }
                    else if (items[i] == "+")
                    {
                        numberToAddToTheStack = result1 + result2;
                    }
                    else if (items[i] == "-")
                    {
                        numberToAddToTheStack = result1 - result2;
                    }
                    Stack.Push(numberToAddToTheStack);
                }
            }
            foreach (var item in Stack)
            {
                Console.WriteLine(item);
            }

        }
    }
}
