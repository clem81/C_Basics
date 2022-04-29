using Inheritance;

Console.WriteLine("Inheritance");

Chef chef = new Chef();
chef.MakeChicken();

ItalianChef italianChef = new ItalianChef();
italianChef.MakeChicken();
italianChef.MakePasta();

chef.MakeSpecialDish();
italianChef.MakeSpecialDish();