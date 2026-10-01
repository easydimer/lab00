Console.WriteLine("Hello, World!");
Console.WriteLine("Choose option:\n1 for leap year check\n2 for even/odd check\n3 for +10");

int choice = int.Parse(Console.ReadLine());

Console.Write("Enter a number/year: ");
int input = int.Parse(Console.ReadLine());

switch (choice)
{
    case 1:
        if ((input % 4 == 0 && input % 100 != 0) || (input % 400 == 0))
            Console.WriteLine("Leap year");
        else
            Console.WriteLine("Not leap year");
        break;

    case 2:
        if (input % 2 == 0)
            Console.WriteLine("Even");
        else
            Console.WriteLine("Odd");
        break;

    case 3:
        Console.WriteLine($"Result: {input + 10}");
        break;

    default:
        Console.WriteLine("Invalid option");
        break;
}