using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisableAccounts
{
    class Program
    {
        static void Main(string[] args)
        {
            
                
            using (SqlConnection connection = new SqlConnection(connectionString)) 
            {
                connection.Open();
                string queryClients = "Select * from Client where First_Name like @nameParameters";

                SqlCommand command = new SqlCommand(queryClients, connection);
                command.Parameters.AddWithValue("@nameParameters", "Leonel");

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("\t{0}\t{1}\t{2}\t{3}\t{4}\t{5}",
                        reader[0],
                        reader[1],
                        reader[2],
                        reader[3],
                        reader[4],
                        reader[5]
                        );
                }
                connection.Close();
            }
            Console.ReadKey();

        }
    }
}
