public static class Program
{
    public static void Main(string[] args)
    {
        //Decalre strings
        string myFirstString = "Hello world";
        Console.WriteLine(myFirstString);

        int myNumber = 42;
        Console.WriteLine(myNumber);

        string myNumberAsString = myNumber.ToString();

        //Manipulating strings;
        //Concatenation

        string firstName = "Bentz";
        string lastName = "Ovidiu Florin";
        string fullName = firstName + " " + lastName; 
        string fullNameWithConcat = string.Concat(firstName," ", lastName);
        Console.WriteLine(fullNameWithConcat);
        Console.WriteLine($"{firstName} {lastName}"); //string interpolation
    }
}