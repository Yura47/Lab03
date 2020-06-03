using System;

namespace lab03_1

{

    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new char[] { '\n', '\r', ' ', ':', ';', '.', ',', '?', '!', '(', ')', '{', '}', '[', ']', '@', '#', '№', '$', '^', '%', '&', '*', '/', '|' }, StringSplitOptions.RemoveEmptyEntries);

            string lngword = words[0];

            foreach (string word in words)

            {

                if (word.Length > lngword.Length)

                {

                    lngword = word;
                }
            }
            string s = "";

            foreach (string word in words)
            {

                int p = 0;

                foreach (char l in word)
                {
                    for (char f = 'a'; f <= 'z'; ++f)

                    {
                        if (l == f)

                        {

                            ++p;

                        }
                    }

                    for (char f = 'A'; f <= 'Z'; ++f)

                    {

                        if (l == f)

                        {

                            ++p;

                        }

                    }

                }
                if (p != word.Length)
                {
                    s += word + " ";

                }
            }
            Console.WriteLine("\n{0}  \n", s);
            Console.WriteLine("The longest word : {0}", lngword);
        }

    }

}