using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLibrary
{
    public class StringReverse
    {
        public string Reverse(string toBeReversed)
        {

            // String reversal code
            string incoming = toBeReversed;
            List<char> reverseList = new List<char>();
            string[] reversedName;

            for (int i = incoming.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(incoming[i]);
                reverseList.Add(incoming[i]);
                Console.WriteLine(reverseList.Cast<string>());
            }

            reversedName = reverseList.Select(x => x.ToString()).ToArray();

            string result = string.Join("", reversedName);

            return result;

            // End string reversal

        }
    }
}
