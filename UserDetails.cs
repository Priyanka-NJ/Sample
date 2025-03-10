using System;
public class UserDetails : Budgets
{
    public void getName()
    {
        Console.Write("\nName : ");
        String ? name = Console.ReadLine();
        if(name == "" )
        {
            Console.WriteLine("The name should not be empty");
            getName();            
        }
    }
    public void getGender()
    {
        Console.Write("\nGender : ");
        String ? gender = Console.ReadLine();
        if(gender == "")
        {
            Console.WriteLine("The gender should not be empty");
            getGender();            
        }
    }
    public void getNumber()
    {
        try
        {
            Console.Write("\nMobile number : ");
            long phonenumber = Convert.ToInt64(Console.ReadLine());
            long intLen = phonenumber.ToString().Length;
            if (intLen != 10)
            {
                Console.Write("Enter 10 digit Mobile Number");
                getNumber();
            }
        }
        catch (Exception e)
        {
                Console.WriteLine(e.Message);
                getNumber();
        }
    }
    public void getAge()
    {
        try
        {
            Console.WriteLine("\nYour Age Must Be Above 40 and below 85");
            Console.Write("\nAge : ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 40 && age <= 85)
            {
                // Console.WriteLine("You are eligible to travel");
            }
            else
            {
                Console.WriteLine("\nEnter the valid age");
                getAge();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            getAge();
        }
       
    }
    public void getIdNumber()
    {
        try
        {
            Console.Write("\nEnter 12 digit ID proof Number : ");
            long idNumber = Convert.ToInt64(Console.ReadLine());
            long intLen = idNumber.ToString().Length; ;
            if (intLen != 12)
            {
                getIdNumber();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            getIdNumber();
        }
    }
    public void getDetails()
    {
        Console.WriteLine("\nCheck the above details and type yes proceed to next step , if the given details is wrong type no\n");
        string ? x = Console.ReadLine();
        if (x == "yes" || x == "Yes" || x == "YES")
        {
            Console.WriteLine("\n**************************************************** Foods and Refreshmet will be provided *****************************************************");
        }
        else if (x == "no" || x == "No" || x == "NO")
        {
            getUserDetails();
        }
        else
        {
            Console.WriteLine("\n\nEnter only Yes or No");
            getDetails();
        }
   
    }
    public override void getUserDetails()
    {
        Console.WriteLine("Please provide the user details");
        for (int i = 1; i <= 2; i++)
        {
            Console.WriteLine("\n........................");
            Console.WriteLine($"  Enter user {i} details ");
            Console.WriteLine("........................");
            getName();
            getAge();   
            getGender();
            getNumber();
            getIdNumber();
            Console.WriteLine("\n-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-");
        }
        getDetails();
    }
}