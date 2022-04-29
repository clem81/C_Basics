using Static_Classes;
using Static_Methods_and_Classes;

Console.WriteLine("Static Classes");

Song backToBlack = new Song("Back to Black", "AC-DC", 240);
Song bohemianRhapsody = new Song("Bohemian Rhapsody", "Queen", 300);
Song ViewToAKill = new Song("A View To a Kill", "Duran Duran", 400 );

Console.WriteLine(backToBlack.title);

//Lines 2 and 11 are a test of using features from another project
UsefulTools.SayHi("Velma");




