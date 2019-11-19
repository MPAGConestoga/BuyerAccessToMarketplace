using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Timers;
using MySql.Data.MySqlClient;

namespace BuyerAccessToMarketplace
{
    public static 
    class MarketplaceAccess
    {
        static volatile bool Run = true;
        static void Main(string[] args)
        {
            //Setup database connection and tables
            Console.WriteLine("{0,-20}\t{1,-10}\t{2,-10}\t{3,-15}\t{4,-15}\t{5,-10}",
                    "Client_Name",
                    "Job_Type",
                    "Quantity",
                    "Origin",
                    "Destination",
                    "Van_Type");

            Thread data = new Thread(new ThreadStart(Database));
            data.Start();
            //Stop pull
            Console.ReadKey();

            //Set running to false
            Run = false;
            data.Join();
            //Exit console
            Console.WriteLine("Press key to quit console.");
            Console.ReadKey();
            //Initial upload of information 
            //Update information and store for 30 rows. 50s
        }

        public static void Database()
        {
            while(Run)
            { 
                //Conncetion for the database 
                string connectionStr = GetConnection();

                MySqlConnection mySqlConnection = new MySqlConnection(connectionStr);
                MySqlCommand command = mySqlConnection.CreateCommand();
                command.CommandText = "SELECT * FROM cmp.Contract";

                try
                {
                    mySqlConnection.Open();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                MySqlDataReader reader = command.ExecuteReader();



                //Reads the rows from the contract marketplace until null
                while (reader.Read())
                {
                    Console.WriteLine("{0,-20}\t{1,-10}\t{2,-10}\t{3,-15}\t{4,-15}\t{5,-10}",
                        reader["Client_Name"].ToString(),
                        reader["Job_Type"].ToString(),
                        reader["Quantity"].ToString(),
                        reader["Origin"].ToString(),
                        reader["Destination"].ToString(),
                        reader["Van_Type"].ToString());
                }
                //Sleep for 10s
                Thread.Sleep(10000);
            }
            Console.WriteLine("Stopped");

        }

        static private string GetConnection()
        {
            string connection = "Server=159.89.117.198;Port = 3306; Database = cmp; Uid = DevOSHT; password = Snodgr4ss!;";
            return connection;
        }
        //Select row -- Also choose the current time of decision of Order picked

        //Class for Customers

        //Method for resetting search list

        //Buyer accepts type of information and gets forwarded into the Database
        

    }
}
