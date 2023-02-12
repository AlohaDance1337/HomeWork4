double GetPow(double number, int degree)
{
    double result = 1;
    for (int i = 0; i< degree;i++)
    {
        result *= number;
    }
    return result;

}

Console.Write("Введите число и его степнь: ");
String strNumber = Console.ReadLine();
String strDegree = Console.ReadLine();
double number = Convert.ToDouble(strNumber);
int degree = Convert.ToInt32(strDegree);


Console.Write($"Полученное число в степени {degree}: {GetPow(number, degree)}");
