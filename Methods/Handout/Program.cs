
readNubers();
getMin(2.5F,3.4F);


int getMin(int number1, int number2)
{
    int min = number1;
    if ( min > number2 )
    {
        min = number2;
    }
    return min;
}

float getMin(float number1, float number2)
{
    float min = number1;
    if (min > number2)
    {
        min = number2;
    }
    return min;
}

 decimal getMin(decimal number1, decimal number2)
{
    decimal min = number1;
    if (min > number2)
    {
        min = number2;
    }
    return min;
}

 void readNubers()
{
    int number1 = int.Parse (Console.ReadLine());

    int number2 = int.Parse (Console.ReadLine());

    Console.WriteLine(getMin(number1, number2));
}
