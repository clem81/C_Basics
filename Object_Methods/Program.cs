using Object_Methods;

Console.WriteLine("Object Methods");

Student student1 = new Student("Chuck", "IT", 3.9);
Student student2 = new Student("Sarah", "Gymnastics", 4.0);
Student student3 = new Student("Morgan", "Home Economics", 1.7);

Console.WriteLine(student1.HasHonours());
Console.WriteLine(student2.HasHonours());
Console.WriteLine(student3.HasHonours());
