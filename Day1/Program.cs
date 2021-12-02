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

Console.WriteLine($"NÚMERO TOTAL DE AUMENTOS:{highers}\n");
Console.ReadKey();