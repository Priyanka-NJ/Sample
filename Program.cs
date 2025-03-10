using System;
using MySql.Data.MySqlClient;
public class TravelAndTourismManagement : Greetings
{
    static string connectionDB = @"server = localhost; userid = root; password =Priya@2520; database=country;";
    MySqlConnection connection = new MySqlConnection(connectionDB);
    public void displayAsia()
    {
        Console.WriteLine("Choose the country you want to vist");
        using(connection){
            try{
                connection.Open();
                string cmd = "select * from asia";
                MySqlCommand command = new MySqlCommand(cmd,connection);
                MySqlDataReader reader = command.ExecuteReader();
                var data = "SNo \tCountries \n";
                if(reader.HasRows){
                    while(reader.Read()){ // data type
                        data += reader.GetInt32(0) + "\t" + reader.GetString(1) + Environment.NewLine;// change value data type
                    }
                    Console.WriteLine(data);
                }
                else
                {
                    Console.WriteLine("Data is empty...");
                }
                connection.Close();
            }
            catch(MySqlException e){
                Console.WriteLine("Error: "+ e.Message.ToString());
            }
        }
        string ? place = Console.ReadLine();
        switch (place)
        {
            case "1":
                Console.WriteLine("You have choosen India");
                Console.WriteLine("We'll take you to each and every tourist places mentioned below");
                dispalyIndia();
                break;
            case "2":
                Console.WriteLine("You have choosen South Korea");
                Console.WriteLine("We'll take you to each and every tourist places mentioned below");
                dispalySouthKorea();
                break;
            case "3":
                Console.WriteLine("You have choosen Thailand");
                Console.WriteLine("We'll take you to each and every tourist places mentioned below");
                dispalyThailand();
                break;
            case "4":
                Console.WriteLine("You have choosen China");
                Console.WriteLine("We'll take you to each and every tourist places mentioned below");
                dispalyChina();
                break;
            case "5":
                Console.WriteLine("You have choosen Japan");
                Console.WriteLine("We'll take you to each and every tourist places mentioned below");
                dispalyJapan();
                break;
            case "6":
                Console.WriteLine("You have choosen Malaysia");
                Console.WriteLine("We'll take you to each and every tourist places mentioned below");
                dispalyMalaysia();
                break;
            case "7":
                Console.WriteLine("You have choosen Vietnam");
                Console.WriteLine("We'll take you to each and every tourist places mentioned below");
                dispalyVietnam();
                break;
            default:
                Console.WriteLine("Enter the valid number");
                displayAsia();
                break;
        }

    }
    public void displayAfrica()
    {
        Console.WriteLine("Choose the country you want to vist");
        using(connection){
            try{
                connection.Open();
                string cmd = "select * from africa";
                MySqlCommand command = new MySqlCommand(cmd,connection);
                MySqlDataReader reader = command.ExecuteReader();
                var data = "SNo \tCountries \n";
                if(reader.HasRows){
                    while(reader.Read()){ // data type
                        data += reader.GetInt32(0) + "\t" + reader.GetString(1) + Environment.NewLine;// change value data type
                    }
                    Console.WriteLine(data);
                }else{
                    Console.WriteLine("Data is empty...");
                    Console.WriteLine("Connection is :"+ connection.State.ToString()+Environment.NewLine);
                }
                connection.Close();
                
            }catch(MySqlException e){
                Console.WriteLine("Error: "+ e.Message.ToString());

            }
        }
        string ? place = Console.ReadLine();
        switch (place)
        {
            case "1":
                Console.WriteLine("You have choosen Egypt");
                Console.WriteLine("We'll take you to each and every tourist places mentioned below");
                dispalyEgypt();
                break;
            case "2":
                Console.WriteLine("You have choosen Morocco");
                Console.WriteLine("We'll take you to each and every tourist places mentioned below");
                dispalyMoroco();
                break;
            case "3":
                Console.WriteLine("You have choosen Nigeria");
                Console.WriteLine("We'll take you to each and every tourist places mentioned below");
                dispalyNigeria();
                break;
            case "4":
                Console.WriteLine("You have choosen Kenya");
                Console.WriteLine("We'll take you to each and every tourist places mentioned below");
                dispalyKenya();
                break;
            case "5":
                Console.WriteLine("You have choosen Algeria");
                Console.WriteLine("We'll take you to each and every tourist places mentioned below");
                dispalyAlgeria();
                break;
            case "6":
                Console.WriteLine("You have choosen Tunisia");
                Console.WriteLine("We'll take you to each and every tourist places mentioned below");
                dispalyTunisia();
                break;
            case "7":
                Console.WriteLine("You have choosen Zimbabwe");
                Console.WriteLine("We'll take you to each and every tourist places mentioned below");
                dispalyZimbabwe();
                break;
            default:
                Console.WriteLine("Enter the valid number");
                displayAfrica();
                break;
        }
    }
    public void displayAmerica()
    {
        Console.WriteLine("Choose the country you want to vist");
        using(connection){
            try{
                connection.Open();
                string cmd = "select * from america";
                MySqlCommand command = new MySqlCommand(cmd,connection);
                MySqlDataReader reader = command.ExecuteReader();
                var data = "SNo \tCountries \n";
                if(reader.HasRows){
                    while(reader.Read()){ // data type
                        data += reader.GetInt32(0) + "\t" + reader.GetString(1) + Environment.NewLine;// change value data type
                    }
                    Console.WriteLine(data);
                }else{
                    Console.WriteLine("Data is empty...");
                    Console.WriteLine("Connection is :"+ connection.State.ToString()+Environment.NewLine);
                }
                connection.Close();
                
            }catch(MySqlException e){
                Console.WriteLine("Error: "+ e.Message.ToString());

            }
        }
        string ? place = Console.ReadLine();
        switch (place)
        {
            case "1":
                Console.WriteLine("You have choosen US");
                Console.WriteLine("We'll take you to each and every tourist places mentioned below");
                dispalyUS();
                break;
            case "2":
                Console.WriteLine("You have choosen Mexico");
                Console.WriteLine("We'll take you to each and every tourist places mentioned below");
                dispalyMexico();
                break;
            case "3":
                Console.WriteLine("You have choosen Peru");
                Console.WriteLine("We'll take you to each and every tourist places mentioned below");
                dispalyPeru();
                break;
            case "4":
                Console.WriteLine("You have choosen Canada");
                Console.WriteLine("We'll take you to each and every tourist places mentioned below");
                dispalyCanada();
                break;
            case "5":
                Console.WriteLine("You have choosen Brazil");
                Console.WriteLine("We'll take you to each and every tourist places mentioned below");
                dispalyBrazil();
                break;
            case "6":
                Console.WriteLine("You have choosen Cuba");
                Console.WriteLine("We'll take you to each and every tourist places mentioned below");
                dispalyCuba();
                break;
            case "7":
                Console.WriteLine("You have choosen Colombia");
                Console.WriteLine("We'll take you to each and every tourist places mentioned below");
                dispalyColombia();
                break;
            default:
                Console.WriteLine("Enter the valid number");
                displayAmerica();
                break;
        }

    }
    private void displayAustralia()
    {
        Console.WriteLine("Choose the country you want to vist");
        using(connection){
            try{
                connection.Open();
                string cmd = "select * from australia";
                MySqlCommand command = new MySqlCommand(cmd,connection);
                MySqlDataReader reader = command.ExecuteReader();
                var data = "SNo \tCountries \n";
                if(reader.HasRows){
                    while(reader.Read()){ // data type
                        data += reader.GetInt32(0) + "\t" + reader.GetString(1) + Environment.NewLine;// change value data type
                    }
                    Console.WriteLine(data);
                }else{
                    Console.WriteLine("Data is empty...");
                    Console.WriteLine("Connection is :"+ connection.State.ToString()+Environment.NewLine);
                }
                connection.Close();
                
            }catch(MySqlException e){
                Console.WriteLine("Error: "+ e.Message.ToString());

            }
        }
        string ? place = Console.ReadLine();
        switch (place)
        {
            case "1":
                Console.WriteLine("You have choosen Sydney");
                Console.WriteLine("We'll take you to each and every tourist places mentioned below");
                dispalySydney();
                break;
            case "2":
                Console.WriteLine("You have choosen Melbourne");
                Console.WriteLine("We'll take you to each and every tourist places mentioned below");
                dispalyMelbourne();
                break;
            case "3":
                Console.WriteLine("You have choosen Perth");
                Console.WriteLine("We'll take you to each and every tourist places mentioned below");
                dispalyPerth();
                break;
            case "4":
                Console.WriteLine("You have choosen Brisbane");
                Console.WriteLine("We'll take you to each and every tourist places mentioned below");
                dispalyBrisbane();
                break;
            case "5":
                Console.WriteLine("You have choosen Canberra");
                Console.WriteLine("We'll take you to each and every tourist places mentioned below");
                dispalyCanberra();
                break;
            case "6":
                Console.WriteLine("You have choosen Adelaide");
                Console.WriteLine("We'll take you to each and every tourist places mentioned below");
                dispalyAdelaide();
                break;
            case "7":
                Console.WriteLine("You have choosen Hobart");
                Console.WriteLine("We'll take you to each and every tourist places mentioned below");
                dispalyHobart();
                break;
            default:
                Console.WriteLine("Enter the valid number");
                displayAustralia();
                break;
        }
    }
    private void displayMiddleEast()
    {
        Console.WriteLine("Choose the country you want to vist");
        using(connection){
            try{
                connection.Open();
                string cmd = "select * from middleeast";
                MySqlCommand command = new MySqlCommand(cmd,connection);
                MySqlDataReader reader = command.ExecuteReader();
                var data = "SNo \tCountries \n";
                if(reader.HasRows){
                    while(reader.Read()){ // data type
                        data += reader.GetInt32(0) + "\t" + reader.GetString(1) + Environment.NewLine;// change value data type
                    }
                    Console.WriteLine(data);
                }else{
                    Console.WriteLine("Data is empty...");
                    Console.WriteLine("Connection is :"+ connection.State.ToString()+Environment.NewLine);
                }
                connection.Close();
                
            }catch(MySqlException e){
                Console.WriteLine("Error: "+ e.Message.ToString());

            }
        }
        string ? place = Console.ReadLine();
        switch (place)
        {
            case "1":
                Console.WriteLine("You have choosen Saudi Arabia");
                Console.WriteLine("We'll take you to each and every tourist places mentioned below");
                dispalySaudiArabia();
                break;
            case "2":
                Console.WriteLine("You have choosen UAE");
                Console.WriteLine("We'll take you to each and every tourist places mentioned below");
                dispalyUAE();
                break;
            case "3":
                Console.WriteLine("You have choosen Egypt");
                Console.WriteLine("We'll take you to each and every tourist places mentioned below");
                dispalyEgypt();
                break;
            case "4":
                Console.WriteLine("You have choosen Iran");
                Console.WriteLine("We'll take you to each and every tourist places mentioned below");
                dispalyIran();
                break;
            case "5":
                Console.WriteLine("You have choosen Oman");
                Console.WriteLine("We'll take you to each and every tourist places mentioned below");
                dispalyOman();
                break;
            case "6":
                Console.WriteLine("You have choosen Qatar");
                Console.WriteLine("We'll take you to each and every tourist places mentioned below");
                dispalyQatar();
                break;
            case "7":
                Console.WriteLine("You have choosen Israel");
                Console.WriteLine("We'll take you to each and every tourist places mentioned below");
                dispalyIsrael();
                break;
            default:
                Console.WriteLine("Enter the valid number");
                displayMiddleEast();
                break;
        }
    }
    private void displayEurope()
    {
        Console.WriteLine("Choose the country you want to vist");
        using(connection){
            try{
                connection.Open();
                string cmd = "select * from europe";
                MySqlCommand command = new MySqlCommand(cmd,connection);
                MySqlDataReader reader = command.ExecuteReader();
                var data = "SNo \tCountries \n";
                if(reader.HasRows){
                    while(reader.Read()){ // data type
                        data += reader.GetInt32(0) + "\t" + reader.GetString(1) + Environment.NewLine;// change value data type
                    }
                    Console.WriteLine(data);
                }else{
                    Console.WriteLine("Data is empty...");
                    Console.WriteLine("Connection is :"+ connection.State.ToString()+Environment.NewLine);
                }
                connection.Close();
                
            }catch(MySqlException e){
                Console.WriteLine("Error: "+ e.Message.ToString());

            }
        }
        string ? place = Console.ReadLine();
        switch (place)
        {
            case "1":
                Console.WriteLine("You have choosen France");
                Console.WriteLine("We'll take you to each and every tourist places mentioned below");
                dispalyFrance();
                break;
            case "2":
                Console.WriteLine("You have choosen Italy");
                Console.WriteLine("We'll take you to each and every tourist places mentioned below");
                dispalyItaly();
                break;
            case "3":
                Console.WriteLine("You have choosen Spain");
                Console.WriteLine("We'll take you to each and every tourist places mentioned below");
                dispalySpain();
                break;
            case "4":
                Console.WriteLine("You have choosen Germany");
                Console.WriteLine("We'll take you to each and every tourist places mentioned below");
                dispalyGermany();
                break;
            case "5":
                Console.WriteLine("You have choosen UK");
                Console.WriteLine("We'll take you to each and every tourist places mentioned below");
                dispalyUK();
                break;
            case "6":
                Console.WriteLine("You have choosen Turkey");
                Console.WriteLine("We'll take you to each and every tourist places mentioned below");
                dispalyTurkey();
                break;
            case "7":
                Console.WriteLine("You have choosen Austria");
                Console.WriteLine("We'll take you to each and every tourist places mentioned below");
                dispalyAustria();
                break;
            default:
                Console.WriteLine("Enter the valid number");
                displayEurope();
                break;
        }
    }
    public void getOpinion()
    {
        Console.WriteLine("Thanks for Choosing G_A_P travels , This trip is only for 2 people..");
        Console.WriteLine("Guide Lines Are Mentioned Below");
        Console.WriteLine("Choose your prefered location\nEnter the number mentioned below for choosing your country\n");
        using(connection){
            try{
                connection.Open();
                string cmd = "select * from country";
                MySqlCommand command = new MySqlCommand(cmd,connection);
                MySqlDataReader reader = command.ExecuteReader();
                var data = "SNo \tCountry \n";
                if(reader.HasRows){
                    while(reader.Read()){ // data type
                        data += reader.GetInt32(0) + "\t" + reader.GetString(1) + Environment.NewLine;// change value data type
                    }
                    Console.WriteLine(data);
                }else{
                    Console.WriteLine("Data is empty...");
                    Console.WriteLine("Connection is :"+ connection.State.ToString()+Environment.NewLine);
                }
                connection.Close();
                
            }catch(MySqlException e){
                Console.WriteLine("Error: "+ e.Message.ToString());

            }
        }
        string ? location = Console.ReadLine();
        switch (location)
        {
            case "1":
                Console.WriteLine("You have choosen Asia");
                displayAsia();
                break;
            case "2":
                Console.WriteLine("You have choosen Africa");
                displayAfrica();
                break;
            case "3":
                Console.WriteLine("You have choosen America");
                displayAmerica();
                break;
            case "4":
                Console.WriteLine("You have choosen Australia");
                displayAustralia();
                break;
            case "5":
                Console.WriteLine("You have choosen Middle East");
                displayMiddleEast();
                break;
            case "6":
                Console.WriteLine("You have choosen Europe");
                displayEurope();
                break;
            default:
                Console.WriteLine("Enter the valid number");
                getOpinion();
                break;
        }
    }
    public void getOpinion(int x){

    }
    public static void Main()
    {
        /*
        Title: Travel and Tourism Management
        Author:Priyanka N J
        Created at: 21-10-2022
        Updated at: 17-11-2022
        Reviewed by: -----------
        Reviewed time: -----------
        Reviewed date: ----------
        */
        TravelAndTourismManagement travelAndTourismManagement = new TravelAndTourismManagement();
        Console.WriteLine("\n-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
        Console.WriteLine("\n-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_ WELCOME TO G_A_P TRAVELS -_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
        Console.WriteLine("\n-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n");
        Console.WriteLine("\nThis Travel Is Only For GOLDEN-AGE People\n");
        travelAndTourismManagement.getOpinion();
        travelAndTourismManagement.getBudget();
        travelAndTourismManagement.getUserDetails();
        travelAndTourismManagement.getPaymentDetails();
        travelAndTourismManagement.displayGreetings();
    }
}