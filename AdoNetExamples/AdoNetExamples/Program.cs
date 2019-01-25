using System;
using System.Data.SqlClient;

namespace AdoNetExamples
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string connectionString = "Data Source=.;Initial Catalog=Library;Integrated Security=True";
            SqlConnection connection = new SqlConnection
            {
                ConnectionString = connectionString
            };

            connection.Open();

            //Console.WriteLine(connection.ServerVersion);

            string selectStatement = "select count(*) from book";
            SqlCommand command = new SqlCommand(selectStatement)
            {
                Connection = connection
            };

            int o = (int)command.ExecuteScalar();

            SqlCommand insertCommand = new SqlCommand();
            insertCommand.Connection = connection;

            string insertText = @"INSERT INTO [dbo].[Book]
                                ([Title]
                                    ,[YearOfPublishing]
                                    ,[NumberOfPages]
                                    ,[HardCover]
                                    ,[AuthorID])
                                  VALUES
                                    ('C# Programming'
                                        , 2018
                                        , 300
                                        , 1
                                        , 1)";

            insertCommand.CommandText = insertText;

            insertCommand.ExecuteNonQuery();

            Console.ReadLine();
        }
    }
}