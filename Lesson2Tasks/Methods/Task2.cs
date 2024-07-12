/*Task 2: Consoldan bir dene string daxil edirsiz.Meselen "Azerbaycan" Bu sozun palindrom olub olmadigin 
yoxlayirsiz */
using System.Diagnostics.CodeAnalysis;

public class Task2
{
    //Nəticəni çap edək
    public static void PrintİsPolindrome()
    {
        Console.WriteLine("Bir string daxil edin:");
        string input = Console.ReadLine().Trim();
        if (Task2.IsPalindrome(input))
        {
            Console.WriteLine($"\"{input}\" sözü palindromdur.");
        }
        else
        {
            Console.WriteLine($"\"{input}\" sözü palindrom deyil.");
        }
    }
    //Verilmiş string-in palindrom olub olmadığını yoxlayaq.
    static bool IsPalindrome(string str)
    {
        // Verilmiş string-in uzunluğunu əldə edirik
        int length = GetLength(str);

        // String-in hər iki tərəfindən müqayisə edirik
        for (int i = 0; i < length / 2; i++)
        {
            if (GetCharAt(str, i) != GetCharAt(str, length - 1 - i))
            {
                return false;
            }
        }
        return true;
    }
    // Verılmış string-in uzunluğunu yoxlayaq və geri qaytaraq.
    static int GetLength(string str)
    {
        int count = 0;
        foreach (char c in str)
        {
            count++;
        }
        return count;
    }
    //Verilmiş string-dəki hər bir elementin sırasıyla yoxlanılması həyata keçirək və istənilən indexdəki elementi geri qaytaraq
    static char GetCharAt(string str, int index)
    {
        int count = 0;
        foreach (char c in str)
        {
            if (count == index)
            {
                return c;
            }
            count++;
        }
        return '\0';
    }
}