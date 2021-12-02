using System;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        //FUNÇÃO MENU => Imprime o menu na tela
        static void Menu()
        {
            int optMenu = 9;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("-------------------");
                Console.WriteLine("Advent of Code 2021");
                Console.WriteLine("-------------------");

                Console.WriteLine("1 - Primeira parte");
                Console.WriteLine("2 - Segunda parte");

                optMenu = int.Parse(Console.ReadLine());

                switch (optMenu)
                {
                    case 1:
                        PrimeiraParte();
                        break;
                    case 2:
                        SegundaParte();
                        break;
                }
            }
        }

        //RESOLUÇÃO DA PRIMEIRA PARTE
        static void PrimeiraParte()
        {
            string[] data = File.ReadAllLines("data.txt").ToArray();

            int highers = 0;

            for (int i = 0; i < data.Length; i++)
            {
                var number = Int32.Parse(data[i]);
                int lastNumber = 0;

                if (i > 0)
                {
                    lastNumber = Int32.Parse(data[i - 1]);
                }
                else
                {
                    lastNumber = 199;
                }

                if (number > lastNumber)
                {
                    highers++;
                    Console.WriteLine($"Último numero: {lastNumber}\nNumero atual: {number} \nNúmero de aumentos: {highers}\n\n");
                }
            }

            Console.WriteLine($"NÚMERO TOTAL DE AUMENTOS: {highers}\n");
            Console.ReadKey();
        }

        //RESOLUÇÃO DA SEGUNDA PARTE
        static void SegundaParte()
        {
            string[] data = File.ReadAllLines("data.txt").ToArray();

            int highers = 0;

            for (int i = 0; i < data.Length; i++)
            {

                if (i < data.Length - 3)
                {
                    int sumB = Int32.Parse(data[i + 1]) + Int32.Parse(data[i + 2]) + Int32.Parse(data[i + 3]);
                    int sumA = Int32.Parse(data[i]) + Int32.Parse(data[i + 1]) + Int32.Parse(data[i + 2]);

                    if (sumB > sumA)
                    {
                        highers++;
                        Console.WriteLine($"Soma anterior: {sumA}\né maior que a soma atual: {sumB} \nNúmero de aumentos: {highers}\n\n");
                    }
                }
            }

            Console.WriteLine($"NÚMERO TOTAL DE AUMENTOS: {highers}\n");
            Console.ReadKey();
        }
    }
}


