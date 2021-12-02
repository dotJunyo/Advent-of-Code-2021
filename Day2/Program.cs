using System;

namespace Day2
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

        //RESOLUÇÃO DA PRIMEIRA PARTE => Algorítimo desenvolvido para encontrar a multiplicação da distância percorrida (Horizontalidade * Profundidade)
        static void PrimeiraParte()
        {
            string[] data = File.ReadAllLines("data.txt").ToArray();

            int horizontal = 0;
            int depth = 0;

            int result = 0;

            Console.Clear();

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].Substring(0, 1) == "f")
                {
                    horizontal += Int32.Parse(data[i].Substring(data[i].Length - 1, 1));
                    Console.WriteLine($"Comando enviado: {data[i]} \nHorizontal: {horizontal}\n");
                }
                else if (data[i].Substring(0, 1) == "d")
                {
                    depth += Int32.Parse(data[i].Substring(data[i].Length - 1, 1));
                    Console.WriteLine($"Comando enviado: {data[i]} \nVertical: {depth}\n");
                }
                else if (data[i].Substring(0, 1) == "u")
                {
                    depth -= Int32.Parse(data[i].Substring(data[i].Length - 1, 1));
                    Console.WriteLine($"Comando enviado: {data[i]} \nVertical: {depth}\n");
                }
            }

            result = horizontal * depth;

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"Horizontal: {horizontal}\nProfundidade: {depth}\n\nO resutado foi: {result}\n");
            Console.ReadKey();
        }
        //RESOLUÇÃO DA SEGUNDA PARTE => Algorítimo desenvolvido para encontrar a multiplicação da distância percorrida (Horizontalidade * Profundidade)
        static void SegundaParte()
        {
            string[] data = File.ReadAllLines("data.txt").ToArray();

            int horizontal = 0;
            int aim = 0;
            int depth = 0;

            Console.Clear();

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].Substring(0, 1) == "f")
                {
                    int sum = Int32.Parse(data[i].Substring(data[i].Length - 1, 1)) * aim;
                    horizontal += Int32.Parse(data[i].Substring(data[i].Length - 1, 1));
                    depth += Int32.Parse(data[i].Substring(data[i].Length - 1, 1)) * aim;

                    Console.WriteLine($"Comando enviado: {data[i]} \nHorizontal: {horizontal}\nProfundidade: {depth}\n");
                }
                else if (data[i].Substring(0, 1) == "d")
                {
                    aim += Int32.Parse(data[i].Substring(data[i].Length - 1, 1));
                    Console.WriteLine($"Comando enviado: {data[i]} \nObjetivo: {aim}\n");
                }
                else if (data[i].Substring(0, 1) == "u")
                {
                    aim -= Int32.Parse(data[i].Substring(data[i].Length - 1, 1));
                    Console.WriteLine($"Comando enviado: {data[i]} \nObjetivo: {aim}\n");
                }
            }

            long result = (long)depth * (long)horizontal;
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"Horizontal: {horizontal}\nObjetivo: {depth}\nProfundidade: {depth}\n\nO resutado foi: {result}\n");
            Console.ReadKey();
        }
    }
}