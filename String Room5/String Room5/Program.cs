using System;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introduceti sirul: ");
        string sir = Console.ReadLine();
        Console.Write("Introsuceti primul caracter: ");
        string firstCharacter = Console.ReadLine();

        if (VerificaPrimaLiteraASirului(sir,firstCharacter))
        {
            Console.WriteLine($"Yes, start with {firstCharacter}!");
        }
        else 
        {
            Console.WriteLine($"No, it start with {firstCharacter}!");
        }

        string inputString = "Hi^>there<<I'm+ telling%%you, you &need% to$ do& your $homeworks. @Hate ^me^ %now% and %thank% me &later.";
        StringBuilder sb = new StringBuilder();
        for (int i=0; i<inputString.Length; i++)
        {
            char ch = inputString[i];
            if ((('a' <= ch) && (ch <= 'z') ) || (('A' <= ch) && (ch <= 'Z')) )
            {
                sb.Append(ch);
            }
            else
            {
                 sb.Append(' ');
            }
        }
        Console.WriteLine(sb.ToString());   

        bool VerificaPrimaLiteraASirului(String sir, String firstCharacter) 
        {
            bool rezultat = false;
 
            if (firstCharacter == sir.Substring(0, 1))
            {
                rezultat = true;
            }      
            return rezultat;
        }
    }
}