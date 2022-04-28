Console.Write("Enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the first number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the first number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The largest number is {GetMax(num1, num2, num3)}");

static int GetMax(int num1, int num2, int num3)
{
    if (num1 > num2 && num1 > num3)
    {
        return num1;
    }
    else if (num2 > num1 && num2 > num3)
    {
        return num2;
    }
    else if (num3 > num1 && num3 > num2)
    {
        return num3;
    }
    else
    {
        return 0;   
    }
}