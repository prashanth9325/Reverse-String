// String reversal code
            string name = "Phillip";
            List<char> reverseList = new List<char>();
            string[] reversedName;
            
            for (i = name.Length - 1; i >= 0; i-- )
            {
                Console.WriteLine(name[i]);
                reverseList.Add(name[i]);
                Console.WriteLine(reverseList.Cast<string>());
            }

            reversedName = reverseList.Select(x => x.ToString()).ToArray();

            string result = string.Join("", reversedName);
            
            Console.WriteLine(result);
            
// End string reversal