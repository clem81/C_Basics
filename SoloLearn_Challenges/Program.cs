// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");





/*
Level Points


Passing the first level of a video game awards the player 1 point. For each subsequent level passed, the points awarded increment by 1 (2 for the 2nd level, 3 for the 3rd, and so on).
The program you are given takes the number of passed levels as input. Complete the given function to take that number as an argument, and recursively calculate and return the total number of points given for all passed levels.


int levels = Convert.ToInt32(Console.ReadLine());
int totalPoints = 0;
for (int i = 1; i <= levels; i++)
{
    totalPoints += i;
}
return totalPoints;
*/

/*Multiple of 3

You are an elementary school teacher and explaining multiplication to students.
You are going to use multiplication by 3 as your example.
The program you are given takes N number as input. Write a program to output all numbers from 1 to N, replacing all numbers that are multiples of 3 by "*".


int number = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i<= number; i++)
{
    if (i % 3 == 0)
    {
        Console.Write("*");
    }
    else
    {
        Console.Write(i);
    }
}
*/