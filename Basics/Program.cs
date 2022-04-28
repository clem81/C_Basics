// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("What is your name: ");
string name = Console.ReadLine();
Console.Write("What is your age: ");
string age = Console.ReadLine();
int ageNum = int.Parse(age);
string phrase = "The quick brown fox jumps over the lazy dog";

Console.WriteLine($"Hello {name}. you are {ageNum + 10}. There are {name.Length} letters in your name");
Console.WriteLine($"upper {name.ToUpper()}, index {phrase.IndexOf("dog")} substring {phrase.Substring(4,5)}");

if (phrase.Contains("fox"))
{
    Console.WriteLine("there is a fox!");
}
else
{
    Console.WriteLine("NO Fox!!");
}
