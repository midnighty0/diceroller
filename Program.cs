Console.WriteLine("Welcome, please select a dice to roll:\n");
Console.WriteLine("Your optiions are:\n d20 \t d12 \t d10 \n d8 \t d6 \t d4 \n coin\n");
Console.Write("Select one: ");


int roll;
string userPointer = Console.ReadLine();

if (userPointer == "d20")

{
    

Random d20 = new();
    
    roll = d20.Next(1,21);

    if (roll == 20)
    {
        Console.WriteLine($"Critical success!\n[{roll}]");
    }
    else if (roll == 1)
    {
        Console.WriteLine($"Critical failure!\n[{roll}]");
    }

    else
    {
        Console.WriteLine($"You rolled a...\n[{roll}]");
    };


}

else if (userPointer == "d12")
{

    Random d12 = new();
    roll = d12.Next(1,13);
    Console.WriteLine($"You rolled a\n[{roll}]");

}

else if (userPointer == "d10")
{
    Random d10 = new();
    roll = d10.Next(1,11);
    Console.WriteLine($"You rolled a\n[{roll}]");
}

else if (userPointer == "d8")
{
    Random d8 = new();
    roll = d8.Next(1,9);
    Console.WriteLine($"You rolled a\n[{roll}]");
}

else if (userPointer == "d6")
{
    Random d6 = new();
    roll = d6.Next(1,7);
    Console.WriteLine($"You rolled a\n[{roll}]");
}

else if (userPointer == "d4")
{
    Random d4 = new();
    roll = d4.Next(1,5);
    Console.WriteLine($"You rolled a\n[{roll}]");
}

else if (userPointer == "coin")
{
    Random coin = new();
    roll = coin.Next(1,3);
    if (roll == 1)
    {
        Console.WriteLine("You got a head");
    }
    else if (roll == 2)
    {
        Console.WriteLine("You got tails");
    }
    else
    {
        Console.WriteLine("Error");
    }
}

else
{
    Console.WriteLine("Invalid Input");
}