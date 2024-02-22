/*• Ex 2: Scrieti un program care va determina daca un numar negativ citit de
la tastatura este divizibil cu 2 si nu este divizibil cu 6
 */
#region console initialization
using System.Text;

Console.BackgroundColor = ConsoleColor.White;

Console.ForegroundColor = ConsoleColor.Black;

Console.Clear();

Console.OutputEncoding = Encoding.UTF8;
#endregion

ShowDivisibility(CheckDivisibility(ReadNumber()));

decimal ReadNumber()
{
    Console.WriteLine("Introduceti un numar negativ pentru a-i fi calculata divizibilitatea cu 2 si 6");
    var numberRaw = Console.ReadLine();
    if (!decimal.TryParse(numberRaw, out decimal number) || number >= 0)
    {
        Console.WriteLine("Nu ati introdus datele in format valid, mai incercati 😒");
        return ReadNumber();
    }

    return number;
}

string CheckDivisibility(decimal number) => number % 2 == 0 ?
                                            (number % 3 != 0 ?
                                            "Numarul este divizibil cu 2 si nu cu 6 👌" :
                                            "Numarul este divizibil cu 6") :
                                            "Numarul nu este divizibil cu 2";

void ShowDivisibility(string divisibility) => Console.WriteLine(divisibility);