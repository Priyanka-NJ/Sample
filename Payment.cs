using System;
public class Payments : UserDetails
{
    protected void getPaymentDetails()
    {
        Console.WriteLine("\n\t\t\t\tEnter the PAYMENT DETAILS\n\n\t\t\t\t Choose the payment method");
        Console.WriteLine("\n\t\t\t\t\t--->1 for UPI Payment");
        Console.WriteLine("\t\t\t\t\t--->2 for Google Payment");
        Console.WriteLine("\t\t\t\t\t--->3 for Net Banking");
        try
        {
        string[] pay = { "UPI Payment", "Google Payment", "Net Banking" };
        int x = Convert.ToInt32(Console.ReadLine());
        if (x > 3 || x < 0)
        {
            Console.WriteLine("\nEnter the valid number");
            getPaymentDetails();
        }
        else
        {
            Console.Write("\nEnter 4-Digit UPI Pin :  ");
            int pinNumber = Convert.ToInt32(Console.ReadLine());
            int pin = pinNumber.ToString().Length;
            if(pin != 4)
            {
            Console.WriteLine("\nEnter the valid pin number");
            getPaymentDetails();
            }
            Console.Write("\nPlease Pay only 3000 USD and remaining amount can be paid at the end of the tour :   ");
            int amount = Convert.ToInt32(Console.ReadLine());
            if (amount == 3000)
            {
                Console.WriteLine("\n> > > > > > > > > > > > > > > > > > > > > > > > > > > > > > >   Payment is Sucessful  < < < < < < < < < < < < < < < < < < < < < < < < < < < < < <");
            }
            else
            {
                Console.WriteLine("\nEnter the valid amount\n\t\tYou are redirected to the payment page");
                getPaymentDetails();
            }
        }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("\nEnter the only number");
            getPaymentDetails();
        }
    }
}