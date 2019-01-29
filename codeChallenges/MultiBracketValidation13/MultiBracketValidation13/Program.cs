using MultiBracketValidation13.Classes;
using System;

namespace MultiBracketValidation13
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        /// <summary>
        /// Takes in a string, searches for brackets, and pushes them into a stack. Then checks to see if the matching bracket exists
        /// </summary>
        /// <param name="input">string</param>
        /// <returns>bool</returns>
        public static bool BracketValidation(string input)
        {
            Stack stack = new Stack();

            for (int index = 0; index < input.Length; index++)
            {
                //Checks for brackets
                if (input[index] == '[' || input[index] == '{' || input[index] == '(')
                {
                    stack.Push(input[index]);
                }
                //checks for matching bracket
                if (input[index] == ']')
                {
                    if (stack.Top != null && stack.Top.Value == '[')
                    {
                        stack.Pop();
                    }
                    else { return false; }
                }

                //checks for matching bracket
                if (input[index] == '}')
                {
                    if (stack.Top != null && stack.Top.Value == '{')
                    {
                        stack.Pop();
                    }
                    else { return false; }
                }

                //checks for matching bracket
                if (input[index] == ')')
                {
                    if (stack.Top != null && stack.Top.Value == '(')
                    {
                        stack.Pop();
                    }
                    else { return false; }
                }
            }

            if (stack.Top == null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}