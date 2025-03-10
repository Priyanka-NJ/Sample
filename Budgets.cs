using System;
using MySql.Data.MySqlClient;

public class Budgets : Transport
{
    public void getBudget()
    {
        string connectionDB = @"server = localhost; userid = root; password =Priya@2520; database=country;";
        MySqlConnection connection = new MySqlConnection(connectionDB);
        Console.WriteLine("\nWe Offer Three plans and budget for your trip and Places will be add on according to the plan you choosing");
        Console.WriteLine("Choose the number displayed before the plan your intrested");
        using(connection){
            try{
                connection.Open();
                string cmd = "select * from plans";
                MySqlCommand command = new MySqlCommand(cmd,connection);
                MySqlDataReader reader = command.ExecuteReader();
                Console.WriteLine("\n--------------------------------------------------------");
                Console.WriteLine("\t\t     Plans and Budget");
                Console.WriteLine("--------------------------------------------------------");
                var data = "SNo \t\tDays \t\tBudget \t\tCurrency\n\n";
                if(reader.HasRows){
                    while(reader.Read()){ // data type
                        data += reader.GetInt32(0) + "\t\t" + reader.GetString(1) + "\t\t" + reader.GetInt32(2) + "\t\t" + reader.GetString(3) + Environment.NewLine;// change value data type
                    }
                    Console.WriteLine(data);
                }
                else
                {
                    Console.WriteLine("Data is empty...");
                }
                connection.Close();
                Console.WriteLine("--------------------------------------------------------");
            }
            catch(MySqlException e){
                Console.WriteLine("Error: "+ e.Message.ToString());
            }
        }
        string ? budget = Console.ReadLine();
        switch (budget)
        {
            case "1":
                Console.WriteLine("\nYou have Choosen 3500 USD as your plan");
                getModeOfTransport1();
                break;
            case "2":
                Console.WriteLine("\nYou have Choosen 4000 USD as your plan");
                getModeOfTransport2();
                break;
            case "3":
                Console.WriteLine("\nYou have Choosen 5000 USD as your plan");
                getModeOfTransport3();
                break;
            default:
                Console.WriteLine("\nEnter the valid number");
                getBudget();
                break;
        }
    }
}