using System.Diagnostics;
using System.Globalization;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;

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

        //Searching in stings
        int index = fullName.IndexOf("Fl");
        Console.WriteLine(index); //6
        Console.WriteLine(fullName.IndexOf("FL")); //-1
        index = fullName.IndexOf("o", 3); //cauta incepand cu indexul 3

        //Extract substring
        //c:/Holiday/2025/1/nice_pic.png

        string path = "c:/Holiday/2025/1/nice_pic.png";
        //search the dot in string
        int indexOfDot = path.IndexOf(".");
        int indexOfLastDot = path.LastIndexOf(".");
        string extension = path.Substring(indexOfDot + 1);

        //extract filename
        int lastIndexOfSlash = path.LastIndexOf("/");
        int substringLength = indexOfLastDot - lastIndexOfSlash - 1;
        string filename = path.Substring(lastIndexOfSlash + 1,substringLength);
        Console.WriteLine($"{filename}.{extension}");

        #region Comapring strings
        string str1 = "Oradea";
        string str2 = "oradea";
        int result = string.Compare(str1, str2);
        Console.WriteLine(result);

        if (str1 == str2)
        {
            //
        }

        if (str1.Equals(str2))
        {

        }

        #endregion

        #region Splitting
        String listOfCities = "Londra, Paris, Iasi, Bucuresti.";
        string[] cities = listOfCities.Split(',', ' ', '.');
        foreach(string city in cities)
        {
            if (!string.IsNullOrEmpty(city))
            {
                Console.WriteLine(city.ToUpper());
            }
            
        }
        #endregion

        //trim
        string  mySpacedString = "     this is a string          ";
        Console.WriteLine(mySpacedString.TrimStart());
        Console.WriteLine(mySpacedString.TrimEnd());
        mySpacedString.Trim();

        string myFunnyString = "-++++++++++this is a string ++++++++++---------";
        Console.WriteLine(myFunnyString.Trim('-', '+'));

        var stopWatch = new Stopwatch();
        string myCoolString = "Counting bottle: ";
        stopWatch.Start();
        for (int i = 0;i<10000;i++)
        {
            myCoolString += i.ToString();
        }
        stopWatch.Stop();
        Console.WriteLine(stopWatch.Elapsed.TotalSeconds.ToString());

        //String formatting
        double d = 0.375;
        string infoToDisplay = d.ToString("P2");
        Console.WriteLine(infoToDisplay);
        string myFormattedString = String.Format("{0:F5}",d);
        Console.WriteLine(myFormattedString);

        //DateTime
        DateTime myDate = DateTime.Now;
        Console.WriteLine(myDate);
        var myFormattedDate = String.Format("{0:d.MM.yyyy HH:mm}", myDate);
        Console.WriteLine(myFormattedDate);

        CultureInfo culture = new CultureInfo("en-US");
        Console.WriteLine(myDate.ToString("d",culture));

        string myDate2 = "01.05.2024";
        var tomorrow = myDate.AddDays(1);
        DateTime futureDate = DateTime.ParseExact(myDate2,"d.MM.yyyy",CultureInfo.InvariantCulture);
        var yesterday = futureDate.AddDays(-1);
        Console.WriteLine(tomorrow.ToString("d",culture));
    }
}