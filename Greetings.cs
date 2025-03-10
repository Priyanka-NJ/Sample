using System;
public class Greetings : Payments
{
    protected internal void displayGreetings()
    {
        Console.WriteLine("\n\t\t()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()");
        Console.WriteLine("\n\t\t------------------------------------------------Thanks for using G_A_P travels------------------------------------------");
        Console.WriteLine("\n\t\t()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()");
        Console.WriteLine("\n\t\t----------------------------------------WE MAKE SURE TO PROVIDE YOU THE BEST SERVICE------------------------------------");
        Console.WriteLine("\n\t\t()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()");
        Console.WriteLine("\nPlease Rate our Service");
        Console.WriteLine("\t 1 for *");
        Console.WriteLine("\t 2 for **");
        Console.WriteLine("\t 3 for ***");
        Console.WriteLine("\t 4 for ****");
        Console.WriteLine("\t 5 for *****");
        int ratings =Convert.ToInt32(Console.ReadLine());
        switch (ratings)
        {
            case 1:
                Console.WriteLine("\n\t\t\tSorry for the inconvenience , We'll try to improve better \n\t\t\t\t\t THANKS FOR RATING US");
                break;
            case 2:
                Console.WriteLine("\n\t\t\tSorry for the inconvenience , We'll try to improve better \n\t\t\t\t\t THANKS FOR RATING US");
                break;
            case 3:
                Console.WriteLine("\n\t\t\toh,That's fine,we make sure to give you the best next time \n\t\t\t\t\t THANKS FOR RATING US");
                break;
            case 4:
                Console.WriteLine("\n\t\t\tCool,we make sure to give you the best next time \n\t\t\t\t\t THANKS FOR RATING US");
                break;
            case 5:
                Console.WriteLine("\n\t\t\tWow,That's great,we make sure to provide you the same next time \n\t\t\t\t\t THANKS FOR RATING US");
                break;
            default:
                Console.WriteLine("\n\t\t\t\t\t\tTHANKS FOR RATING US");
                break;
        }

    }
}