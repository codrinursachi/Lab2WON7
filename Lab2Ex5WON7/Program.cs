/*Ex 5: Să se scrie un program care citeşte de la tastatură un şir de n numere
naturale şi determină media aritmetică a celor pare, n fiind citit de la
tastatura*/
#region console initialization
using System.Text;

Console.BackgroundColor = ConsoleColor.White;

Console.ForegroundColor = ConsoleColor.Black;

Console.Clear();

Console.OutputEncoding = Encoding.UTF8;
#endregion

ShowEvenNumbersAverage(ComputeEvenNumbersAverage(ReadArrayNumbers(ReadArrayLength())));

int ReadArrayLength()
{
    Console.WriteLine("Introduceti lungimea sirului");
    var arrayLength = Console.ReadLine();
    if (!int.TryParse(arrayLength, out int number) || number < 1)
    {
        Console.WriteLine("Nu ati introdus datele in format valid, mai incercati 😒");
        return ReadArrayLength();
    }
    return number;
}

int[] ReadArrayNumbers(int arrayLength)
{
    Console.WriteLine($"Introduceti un sir de {arrayLength} elemente");
    string[] arrayRaw = Console.ReadLine()!.Split();
    if (arrayRaw.Length != arrayLength)
    {
        Console.WriteLine("Nu ati introdus numarul corect de elemente, mai incercati 😒");
        ReadArrayNumbers(arrayLength);
    }
    int[] array = new int[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        if (!int.TryParse(arrayRaw[i], out array[i]))
        {
            Console.WriteLine("Nu ati introdus datele in format valid, mai incercati 😒");
            ReadArrayNumbers(arrayLength);
        }
    }
    return array;
}

decimal ComputeEvenNumbersAverage(int[] array)
{
    decimal sum = default;
    decimal evenNumbers = default;
    foreach (int number in array)
    {
        if (int.IsEvenInteger(number))
        {
            sum += number;
            evenNumbers++;
        }
    }
    if (evenNumbers == 0)
    {
        Console.WriteLine("Nu aveti numere pare, mai incercati 😒");
        return ComputeEvenNumbersAverage(ReadArrayNumbers(ReadArrayLength()));
    }
    return (decimal)sum / evenNumbers;
}

void ShowEvenNumbersAverage(decimal average) => Console.WriteLine(average + " 👌");