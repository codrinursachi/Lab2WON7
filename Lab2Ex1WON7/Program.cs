/*
 * Ex 1: Scrieti un program care va calcula valoarea urmatoarei functii pentru
   x citit de la tastatura
 */
#region console initialization
using System.Text;

Console.BackgroundColor = ConsoleColor.White;

Console.ForegroundColor = ConsoleColor.Black;

Console.Clear();

Console.OutputEncoding = Encoding.UTF8;
#endregion
try
{
    checked
    {
        ShowResult(ComputeCorrespondingBranch(ReadNumber()));
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Nu putem lucra cu numere de asemenea magnitudine \n {ex.Message} 😒");
}


decimal ReadNumber()
{
    Console.WriteLine("Introduceti un numar pentru a-i fi calculata functia corespunzatoare");
    var numberRaw = Console.ReadLine();
    if (!decimal.TryParse(numberRaw, out decimal number))
    {
        Console.WriteLine("Nu ati introdus datele in format valid, mai incercati 😒");
        return ReadNumber();
    }

    return number;
}
decimal ComputeCorrespondingBranch(decimal number) => number switch
{
    <= -2 => 7 * number * number,
    <= 0.5M => 4 * number - 5,
    _ => 14 * number - 7,
};

void ShowResult(decimal result) => Console.WriteLine(result + " 👌");