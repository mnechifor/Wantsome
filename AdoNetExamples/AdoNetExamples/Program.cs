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

            Console.WriteLine("Please enter book name:");
            string bookName = Console.ReadLine();

            string selectStatement = "select count(*) from book";
            SqlCommand command = new SqlCommand(selectStatement)
            {
                Connection = connection
            };

            int o = (int)command.ExecuteScalar();

            InsertNewBook(connection, bookName);

            Console.ReadLine();
        }

        private static void InsertNewBook(SqlConnection connection, string bookName)
        {
            SqlCommand insertCommand = new SqlCommand();
            insertCommand.Connection = connection;

            SqlParameter bookParameter = new SqlParameter();
            bookParameter.Value = bookName;
            bookParameter.ParameterName = "bookName";

            string insertText = @"INSERT INTO [dbo].[Book]
                                ([Title]
                                    ,[YearOfPublishing]
                                    ,[NumberOfPages]
                                    ,[HardCover]
                                    ,[AuthorID])
                                  VALUES
                                    (@bookName
                                        , 2018
                                        , 300
                                        , 1
                                        , 1);
            SELECT CAST(scope_identity() AS int)";

            insertCommand.CommandText = insertText;
            insertCommand.Parameters.Add(bookParameter);

            int Id = (int) insertCommand.ExecuteScalar();
        }
    }
}