using System;
using MySql.Data.MySqlClient;

public class Transport : TouristPlaces
{
    public void getModeOfTransport1()
    {
        string connectionDB = @"server = localhost; userid = root; password =Priya@2520; database=country;";
        MySqlConnection connection = new MySqlConnection(connectionDB);
        Console.WriteLine("\nHow do you want to travel ?");
        Console.WriteLine("Choose any one of the below option"); 
        using(connection){
            try{
                connection.Open();
                string cmd = "select * from transport";
                MySqlCommand command = new MySqlCommand(cmd,connection);
                MySqlDataReader reader = command.ExecuteReader();
                Console.WriteLine("\n----------------------------------------------------------------");
                Console.WriteLine("\t\t      Transport and Budget");
                Console.WriteLine("----------------------------------------------------------------");
                var data = "SNo \t\tTransport \t\tBudget \t\tCurrency\n\n";
                if(reader.HasRows){
                    while(reader.Read()){ // data type
                        data += reader.GetInt32(0) + "\t\t" + reader.GetString(1) + "\t\t" + reader.GetInt32(2) + "\t\t" + reader.GetString(3) + Environment.NewLine;// change value data type
                    }
                    Console.WriteLine(data);
                }else{
                    Console.WriteLine("Data is empty...");
                    Console.WriteLine("Connection is :"+ connection.State.ToString()+Environment.NewLine);
                }
                Console.WriteLine("----------------------------------------------------------------");
                connection.Close();
                
            }catch(MySqlException e){
                Console.WriteLine("Error: "+ e.Message.ToString());

            }
        }
        int[] transportPrice = { 450, 350, 270, 800, 200 }; //array
        try{
            int transport = Convert.ToInt32(Console.ReadLine());
            int x = 3500 + transportPrice[transport - 1];
            switch (transport)
            {
                case 1:
                Console.WriteLine("\nYou have choosen Private Jet");
                Console.WriteLine($"Total Price is {x} USD");
                break;
                case 2:
                Console.WriteLine("\nYou have choosen Mini Jet");
                Console.WriteLine($"Total Price is {x} USD");
                break;
                case 3:
                Console.WriteLine("\nYou have choosen Airlines");
                Console.WriteLine($"Total Price is {x} USD");
                break;
                case 4:
                Console.WriteLine("\nYou have choosen Private Ship");
                Console.WriteLine($"Total Price is {x} USD");
                break;
                case 5:
                Console.WriteLine("\nYou have choosen Private Van");
                Console.WriteLine($"Total Price is {x} USD");
                break;
                default:
                Console.WriteLine("\nEnter the valid number");
                getModeOfTransport1();
                break;
            }
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("\nEnter the only number");
            getModeOfTransport1();
        }
    }
    public void getModeOfTransport2()
    {
        string connectionDB = @"server = localhost; userid = root; password =Priya@2520; database=country;";
        MySqlConnection connection = new MySqlConnection(connectionDB);
        Console.WriteLine("\nHow do you want to travel ?");
        using(connection){
            try{
                connection.Open();
                string cmd = "select * from transport";
                MySqlCommand command = new MySqlCommand(cmd,connection);
                MySqlDataReader reader = command.ExecuteReader();
                Console.WriteLine("\n----------------------------------------------------------------");
                Console.WriteLine("\t\t      Transport and Budget");
                Console.WriteLine("----------------------------------------------------------------");
                var data = "SNo \t\tTransport \t\tBudget \t\tCurrency\n\n";
                if(reader.HasRows){
                    while(reader.Read()){ // data type
                        data += reader.GetInt32(0) + "\t\t" + reader.GetString(1) + "\t\t" + reader.GetInt32(2) + "\t\t" + reader.GetString(3) + Environment.NewLine;// change value data type
                    }
                    Console.WriteLine(data);
                }else{
                    Console.WriteLine("Data is empty...");
                    Console.WriteLine("Connection is :"+ connection.State.ToString()+Environment.NewLine);
                }
                connection.Close();
                Console.WriteLine("----------------------------------------------------------------");
            }
            catch(MySqlException e){
                Console.WriteLine("Error: "+ e.Message.ToString());

            }
        }
        int[] transportPrice = { 450, 350, 270, 800, 200 };
        try{ 
            int transport =Convert.ToInt32(Console.ReadLine());
            int x = 4000 + transportPrice[transport - 1];
            switch (transport)
            {
            case 1:
                Console.WriteLine("\nYou have choosen Private Jet");
                Console.WriteLine($"Total Price is {x} USD");
                break;
            case 2:
                Console.WriteLine("\nYou have choosen Mini Jet");
                Console.WriteLine($"Total Price is {x} USD");
                break;
            case 3:
                Console.WriteLine("\nYou have choosen Airlines");
                Console.WriteLine($"Total Price is {x} USD");
                break;
            case 4:
                Console.WriteLine("\nYou have choosen Private Ship");
                Console.WriteLine($"Total Price is {x} USD");
                break;
            case 5:
                Console.WriteLine("\nYou have choosen Private Van");
                Console.WriteLine($"Total Price is {x} USD");
                break;
            default:
                Console.WriteLine("\nEnter the valid number");
                getModeOfTransport2();
                break;
            }
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("\nEnter the only number");
            getModeOfTransport2();
        }
    }
    public void getModeOfTransport3()
    {
        string connectionDB = @"server = localhost; userid = root; password =Priya@2520; database=country;";
        MySqlConnection connection = new MySqlConnection(connectionDB);
        Console.WriteLine("\nHow do you want to travel ?");
        Console.WriteLine("Choose any one of the below option");
        using(connection){
            try{
                connection.Open();
                string cmd = "select * from transport";
                MySqlCommand command = new MySqlCommand(cmd,connection);
                MySqlDataReader reader = command.ExecuteReader();
                Console.WriteLine("\n----------------------------------------------------------------");
                Console.WriteLine("\t\t      Transport and Budget");
                Console.WriteLine("----------------------------------------------------------------");
                var data = "SNo \t\tTransport \t\tBudget \t\tCurrency\n\n";
                if(reader.HasRows){
                    while(reader.Read()){ // data type
                        data += reader.GetInt32(0) + "\t\t" + reader.GetString(1) + "\t\t" + reader.GetInt32(2) + "\t\t" + reader.GetString(3) + Environment.NewLine;// change value data type
                    }
                    Console.WriteLine(data);
                }else{
                    Console.WriteLine("Data is empty...");
                    Console.WriteLine("Connection is :"+ connection.State.ToString()+Environment.NewLine);
                }
                connection.Close();
                Console.WriteLine("----------------------------------------------------------------");
            }
            catch(MySqlException e){
                Console.WriteLine("Error: "+ e.Message.ToString());

            }
        }
        int[] transportPrice = { 450, 350, 270, 800, 200 };
        try{
            int transport = Convert.ToInt32(Console.ReadLine());
            int x = 5000 + transportPrice[transport - 1];
            switch (transport)
            {
            case 1:
                Console.WriteLine("\nYou have choosen Private Jet");
                Console.WriteLine($"Total Price is {x} USD");
                break;
            case 2:
                Console.WriteLine("\nYou have choosen Mini Jet");
                Console.WriteLine($"Total Price is {x} USD");
                break;
            case 3:
                Console.WriteLine("\nYou have choosen Airlines");
                Console.WriteLine($"Total Price is {x} USD");
                break;
            case 4:
                Console.WriteLine("\nYou have choosen Private Ship");
                Console.WriteLine($"Total Price is {x} USD");
                break;
            case 5:
                Console.WriteLine("\nYou have choosen Private Van");
                Console.WriteLine($"Total Price is {x} USD");
                break;
            default:
                Console.WriteLine("\nEnter the valid number");
                getModeOfTransport3();
                break;
            }
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("\nEnter the only number");
            getModeOfTransport3();
        }
    }
    public virtual void getUserDetails()
    {
        Console.WriteLine("\nPlease provide the user details");
        Console.WriteLine("Check the above details and type yes proceed to next step , if the given details is wrong type no");
        string ? x = Console.ReadLine();
    }
}