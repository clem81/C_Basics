using Classes_And_Objects;

Console.WriteLine("Classes and Objects");

/*
This block created the items using the class properties before the constructor was created 
Book book1 = new Book();
book1.title = "Jurassic Park";
book1.author = "Michael Crichton";
book1.pages = 400;

Book book2 = new Book();
book2.title = "The Lord of the Rings";
book2.author = "J R R Tolkien";
book2.pages = 1800;
*/
Book book1 = new Book("The Colour of Magic", "Terry Pratchett", 380);

Book book2 = new Book(); //This now uses the empty constructor
book2.title = "The Lord of the Rings";
book2.author = "J R R Tolkien";
book2.pages = 1800;

Console.WriteLine($"The amazing story of {book1.title} was written by {book1.author} and is approximately {book1.pages} pages long");

Console.WriteLine($"The amazing story of {book2.title} was written by {book2.author} and is approximately {book2.pages} pages long");
