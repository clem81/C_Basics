// See https://aka.ms/new-console-template for more information
Console.WriteLine("Methods");
SayHi();
takeName("Snoopy");
Console.WriteLine(addingNumbers(3, 6));

static void SayHi()
{
    Console.WriteLine("Saying hello");
    Console.WriteLine("Methods return nothing and are VOID! Same as Python procedures");
}

static void takeName(string name)
{
    Console.WriteLine($"Hey there {name}");
        }

static int addingNumbers(int num1, int num2)
{
    return num1 + num2;
}