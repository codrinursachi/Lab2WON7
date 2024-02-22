﻿/*Ex 4: Scrieti un program care va afisa factorialul unui numar n, n fiind citit
de la tastatura.
 */
#region console initialization
using System.Text;

Console.BackgroundColor = ConsoleColor.White;

Console.ForegroundColor = ConsoleColor.Black;

Console.Clear();

Console.OutputEncoding = Encoding.UTF8;
#endregion

ShowFactorial(ComputeFactorial(ReadNumber()));

int ReadNumber()
{
    Console.WriteLine("Introduceti un numar pentru a-i fi calculat factorialul");
    var numberRaw = Console.ReadLine();
    if (!int.TryParse(numberRaw, out int number) || number < 1)
    {
        Console.WriteLine("Nu ati introdus datele in format valid, mai incercati 😒");
        return ReadNumber();
    }
    return number;
}

int ComputeFactorial(int number) => number == 1 ? 1 : number * ComputeFactorial(number - 1);

void ShowFactorial(int number) => Console.WriteLine(number + " 👌");