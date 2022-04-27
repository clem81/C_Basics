using Getters_And_Setters;

Console.WriteLine("Getters and Setters");


Movie avengers = new Movie("The Avengers", "Joss Whedon", "12A");
Movie jurassicPark = new Movie("Jurassic Park", "Steven Spielberg", "12A");
Movie jaws = new Movie("Jaws", "Steven Spielberg", "15");
Movie rubbishRating = new Movie("valid title", "valid director", "inValid rating");

Console.WriteLine(rubbishRating.Rating)