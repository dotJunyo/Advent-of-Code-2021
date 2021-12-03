using System;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeiraParte();
        }

        static void PrimeiraParte()
        {
            Console.Clear();

            string[] data = File.ReadAllLines("data.txt").ToArray();

            int gamma = 0;
            int epsilon = 0;

            string binaries = string.Empty;
            string invertBinaries = string.Empty;

            for (int x = 0; x < 12; x++)
            {
                int zero = 0;
                int one = 0;
                foreach (string s in data)
                {
                    if (s.Substring(x, 1) == "0")
                    {
                        zero++;
                    }
                    else
                    {
                        one++;
                    }
                }
                if (zero > one)
                {
                    binaries += "0";
                }
                else
                {
                    binaries += "1";
                }
            }

            for (int i = 0; i < binaries.Length; i++)
            {
                if (binaries.Substring(i, 1) == "0")
                {
                    invertBinaries += "1";
                }
                else
                {
                    invertBinaries += "0";
                }
            }

            gamma = Convert.ToInt32(binaries, 2);
            epsilon = Convert.ToInt32(invertBinaries, 2);

            Console.WriteLine($"Gamma * Epsilon = {gamma * epsilon}");

        }
    }
}