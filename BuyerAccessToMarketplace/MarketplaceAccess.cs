using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace BuyerAccessToMarketplace
{
    class MarketplaceAccess
    {
        static void Main(string[] args)
        {
            //Conncetion for the database 
            string connectionStr = GetConnection(); 
            //Setup database connection and tables
            Database(connectionStr);
            //Initial upload of information 
        }

        public static void Database(string connection)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connection);
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

            Console.WriteLine("{0,-20}\t{1,-10}\t{2,-10}\t{3,-15}\t{4,-15}\t{5,-10}",
                                "Client_Name",
                                "Job_Type",
                                "Quantity",
                                "Origin",
                                "Destination",
                                "Van_Type");

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

            Console.ReadLine();

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
