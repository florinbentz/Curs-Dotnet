using System;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introduceti adresa de email: ");
        String email = Console.ReadLine();
        int positionAt = email.IndexOf("@"); 
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < email.Length; i++)
        {
            if (i < positionAt)
            {
                sb.Append("*");            
            }else
            {
                sb.Append(email[i]);
            }
        }
        Console.Write("Emailul protejat este: ");
        Console.WriteLine(sb.ToString());    
    }
}