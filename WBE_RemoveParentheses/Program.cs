/**
 * Write a function that accepts a string, removes all characters between parentheses, then returns the modified string
 * ie: "one (two) three" should return "one () three"
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace WBE_RemoveParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.Write("Input a string\n\n>>> ");
                    string input = Console.ReadLine();
                    Console.WriteLine(RemoveParentheses(input));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n" + ex.Message);
                }
                Console.Write("\nPress Enter to try another string...");
                Console.ReadLine();
                Console.Clear();
            } while (true);
        }

        static string RemoveParentheses(string input)
        {
            string output = "";
            bool include = true;
            Queue myQ = new Queue();
            foreach (var ch in input)
            {
                if (ch == '(')
                {
                    output += ch;
                    include = false;
                }
                else if (ch == ')')
                {
                    include = true;
                }
                if (include)
                {
                    output += ch;
                }
            }
            return output;
        }
    }
}
