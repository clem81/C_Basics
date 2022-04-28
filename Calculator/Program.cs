// See https://aka.ms/new-console-template for more information

Console.WriteLine("Calculator program");
Console.WriteLine("------------------");
Console.Write("Enter a number: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter a number: ");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the calculation type, +, -, *, /: ");
string calcType = Console.ReadLine();

Answer(num1, num2, calcType);

static double addition(double int1, double int2)
{
    return int1 + int2;
}

static double subtraction(double int1, double int2)
{
    return (int1 - int2);
}

static double divide(double int1, double int2)
    => int1 / int2;

static double multiply(double int1, double int2)
    => int1 * int2;

static void Answer(double num1, double num2, string calcType)
{
    double result;

    if (calcType == "+")
    {
        result = addition(num1, num2);
    }
    else if (calcType == "-")
    {
        result = subtraction(num1, num2);
    }
    else if (calcType == "/")
    {
        result = divide(num1, num2);
    }
    else if (calcType == "*")
    {
        result = multiply(num1, num2);
    }
    else
    {
        result = 0;
        Console.WriteLine("Invalid operator");
    }
    Console.WriteLine($"The answer is {result}");
}