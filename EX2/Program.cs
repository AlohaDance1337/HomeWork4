int SumOfDigits(int number)
{
    int sum = 0;
    while(number > 0)
    {
        sum += number % 10;
        number/=10;
    }
    return sum;
}

Console.Write("Введите число: ");
String strNumber = Console.ReadLine();
int number = Convert.ToInt32(strNumber);

Console.Write($"{SumOfDigits(number)}");
