using System;

using System.IO;



namespace lab03_2

{

    class Prog

    {

        static void Main(string[] args)

        {

            StreamReader file = new StreamReader("file.txt");



            string[] nmbrs = file.ReadToEnd().Split(new char[] { '\r', '\n', ' ' }, StringSplitOptions.RemoveEmptyEntries);



            int[] p = new int[nmbrs.Length];



            for (int i = 0; i < nmbrs.Length; ++i)

            {

                p[i] = int.Parse(nmbrs[i]);

            }



            int k = 0;



            for (int i = 0; i < nmbrs.Length; ++i)

            {

                if (p[i] % 2 != 0)

                {

                    ++k;

                }

            }



            Console.WriteLine("К-кість непарних чисел =  {0}", k);



            if (k != 0)

            {

                Console.Write("Непарні числа :");



                for (int i = 0; i < nmbrs.Length; ++i)

                {

                    if (p[i] % 2 != 0)

                    {

                        Console.Write(" {0}", p[i]);

                    }

                }

            }

        }

    }

}