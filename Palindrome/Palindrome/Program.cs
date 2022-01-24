//Paindrome:

class Program
{
    static void Main()
    {
        do
        {
            Console.WriteLine("Write a text:");
            String textBase = Console.ReadLine();
            char[] textChar = textBase.Replace( " ", "").ToCharArray();

            if (IsPali(textChar))
                Console.WriteLine(textBase + " is palindrome");
            else
                Console.WriteLine(textBase + " is not palindrome");
            
        } while (CheckContinue());
    }

    private static bool CheckContinue()
    {
        Console.WriteLine("do you wish to continue? (y, n);");
        var wish = (char)Console.Read();
        Console.ReadLine();
        return wish is 'y' or 'Y'; 
    }

    static bool IsPali(char[] textChar)
    {
        var textLength = textChar.Length;
        for (int i = 0; i < textLength; i++ , textLength--)
        {
            if (textChar[i] != textChar[textLength-1])
                return false;
        }
        return true;
    }
    
}
