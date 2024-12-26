// See https://aka.ms/new-console-template for more information
{

    string FirstName;
    string LastName;
    int Age;
    char Gender;


    {
        FirstName = "Raluca";
        LastName = "Frisan";
        Age = 24;
        Gender = 'F';
        int yearinfuture = Age + 20;

        Console.WriteLine("Please input your First Name: ");
        Console.ReadLine();

        Console.WriteLine("Please input your Last Name: ");
        Console.ReadLine();

        Console.WriteLine("Please input your Age: ");
        Console.ReadLine();

        Console.WriteLine("Please input your Gender: ");
        Console.ReadLine();

        Console.WriteLine("Your details are as follows: ");
        Console.WriteLine("- First Name: " + FirstName);
        Console.WriteLine("- Last Name: " + LastName);
        Console.WriteLine("- Gender: " + Gender);
        Console.Write("You will be " + yearinfuture + " years old in 20 years!");
    }
}
