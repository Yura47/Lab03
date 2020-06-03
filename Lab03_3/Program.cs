using System;

using System.IO;



namespace lab03_3

{

    class Program

    {

        static void Main(string[] args)

        {

            StreamReader file = new StreamReader("input.txt");



            string[] wrds = file.ReadToEnd().Split(new char[] { '\r', '\n', ' ' }, StringSplitOptions.RemoveEmptyEntries);



            for (int i = 0; i < wrds.Length; ++i)

            {

                if (wrds[i] == wrds[i].ToLower())

                {

                    wrds[i] = wrds[i].Remove(0);

                }

            }



            StreamWriter newFile = File.CreateText("output.txt");



            foreach (string word in wrds)

            {

                if (!string.IsNullOrWhiteSpace(word))

                {

                    newFile.Write("{0} ", word);

                }

            }



            newFile.Close();

        }

    }

}