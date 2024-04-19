using System;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        string inputString = "Hi^>there<<I'm+ telling%%you, you &need% to$ do& your $homeworks. @Hate ^me^ %now% and %thank% me &later.";
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < inputString.Length; i++)
        {
            char ch = inputString[i];
            if ((('a' <= ch) && (ch <= 'z')) || (('A' <= ch) && (ch <= 'Z')) || (ch==39) || (ch == '.'))
                //nu stiu cum scrie caracterul apostrof altfel decat prin codul unicode ' == 39
            {
                sb.Append(ch);
            }
            else
            {
                sb.Append(' ');
            }
        }
        string rezultat = sb.ToString();
        while (rezultat.IndexOf("  ") > 0)
        {
            rezultat = rezultat.Replace("  ", " ");
        }
        Console.WriteLine(rezultat);
    }
}