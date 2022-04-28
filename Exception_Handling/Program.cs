
try
{
Console.Write("Enter a number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(num1 / num2);
}
catch (DivideByZeroException e)
{
    Console.WriteLine(e.Message);
}

catch (Exception e)
{
    Console.WriteLine($"You made an error! {e.Message}");
    
}
finally
{
    Console.WriteLine("Some message that happens every time");
}

