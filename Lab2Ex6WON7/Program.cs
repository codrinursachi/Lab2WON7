/*Ex 6: Scrieti un program care va determina daca un numar este sau nu
palindrom.
*/
#region console initialization
using System.Text;

Console.BackgroundColor = ConsoleColor.White;

Console.ForegroundColor = ConsoleColor.Black;

Console.Clear();

Console.OutputEncoding = Encoding.UTF8;
#endregion

ShowPalindrome(CheckPalindrome(ReadNumber()));

string ReadNumber()
{
    Console.WriteLine("Introduceti un numar pentru a se verifica daca e palindrom");
    var numberRaw = Console.ReadLine();
    if (!int.TryParse(numberRaw, out _))
    {
        Console.WriteLine("Nu ati introdus datele in format valid, mai incercati 😒");
        return ReadNumber();
    }
    return numberRaw;
}

string CheckPalindrome(string numberRaw) => numberRaw == new string(numberRaw.Reverse().ToArray()) ? "Numarul este palindrom 👌" : "Numarul nu este palindrom";

void ShowPalindrome(string result) => Console.WriteLine(result);