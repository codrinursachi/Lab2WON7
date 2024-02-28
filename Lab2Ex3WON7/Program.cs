/*Ex 3: Scrieti un program care va afisa suma cifrelor unui numar n, n fiind
citit de la tastatura.
 */
#region console initialization
using System.Text;

Console.BackgroundColor = ConsoleColor.White;

Console.ForegroundColor = ConsoleColor.Black;

Console.Clear();

Console.OutputEncoding = Encoding.UTF8;
#endregion

ShowSum(ComputeDigitSum(ReadNumber()));

int ReadNumber()
{
    Console.WriteLine("Introduceti un numar pentru a-i fi calculata suma cifrelor");
    var numberRaw = Console.ReadLine();
    numberRaw = numberRaw?[0] == '-' ? numberRaw[1..] : numberRaw;
    if (!int.TryParse(numberRaw, out int number))
    {
        Console.WriteLine("Nu ati introdus datele in format valid, mai incercati 😒");
        return ReadNumber();
    }
    return number;
}

int ComputeDigitSum(int number)
{
    int sum = default;
    while (number > 0)
    {
        sum += number%10;
        number /=10;
    }
    return sum;
}

void ShowSum(int sum) => Console.WriteLine(sum + " 👌");