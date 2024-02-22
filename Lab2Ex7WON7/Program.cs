/*Ex 7 (pentru cei care nu l-au rezolvat cu “if”): Se citesc trei numere de la
tastatura, x,y,z. Scrieti un program care va afisa cele trei valori in ordine
descrescatoare.
• Exemplu: citim 3 9 0 Afisam : 9 3 0*/
#region console initialization
using System.Text;

Console.BackgroundColor = ConsoleColor.White;

Console.ForegroundColor = ConsoleColor.Black;

Console.Clear();

Console.OutputEncoding = Encoding.UTF8;
#endregion

ShowNumbersDescending(SortNumbersDescending(ReadNumbers()));

int[] ReadNumbers()
{
    Console.WriteLine("Introduceti 3 numere pentru a le sorta descrescator");
    var numbersRaw = Console.ReadLine()!.Split();
    if (numbersRaw.Length != 3)
    {
        Console.WriteLine("Nu ati introdus datele intrun format valid, mai incercati 😒");
    }
    int[] numbers = new int[3];
    for (int i = 0; i < 3; i++)
    {
        if (!int.TryParse(numbersRaw[i], out numbers[i]))
        {
            Console.WriteLine("Nu ati introdus datele intrun format valid, mai incercati 😒");
            return ReadNumbers();
        }
    }
    return numbers;
}

int[] SortNumbersDescending(int[] numbers)
{
    if (numbers[0] < numbers[1])
    {
        (numbers[0], numbers[1]) = (numbers[1], numbers[0]);
    }
    if (numbers[1] < numbers[2])
    {
        (numbers[1], numbers[2]) = (numbers[2], numbers[1]);
    }
    if (numbers[0] < numbers[1])
    {
        (numbers[0], numbers[1]) = (numbers[1], numbers[0]);
    }
    return numbers;
}

void ShowNumbersDescending(int[] numbers) => Console.WriteLine($"Numerele in ordine descrescatoare sunt {numbers[0]}, {numbers[1]} si {numbers[2]} 👌");