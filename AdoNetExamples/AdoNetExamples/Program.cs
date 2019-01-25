using System;
using System.Data;
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

           // Console.WriteLine("Please enter book name:");
           // string bookName = Console.ReadLine();

            try
            {
                string selectStatement = "select count(*) from book11";
                SqlCommand command = new SqlCommand(selectStatement)
                {
                    Connection = connection
                };

                int o = (int) command.ExecuteScalar();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
               // connection.Close();
            }

            //InsertNewBook(connection, bookName);
            
            string selectAllBooks = "GetAllBooks";
            SqlCommand selectCommand = new SqlCommand(selectAllBooks);
            selectCommand.Connection = connection;

            selectCommand.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = selectCommand.ExecuteReader();
            
            while (reader.Read())
            {
                string book = $"{reader["Id"]}, {reader[1]}";
                Console.WriteLine(book);
            }

            reader.Close();
            
            connection.Close();

            Console.ReadLine();
        }

        private static void InsertNewBook(SqlConnection connection, string bookName)
        {
            SqlCommand insertCommand = new SqlCommand
            {
                Connection = connection
            };

            SqlParameter bookParameter = new SqlParameter
            {
                Value = bookName,
                ParameterName = "bookName"
            };

            string insertText = @"INSERT INTO [dbo].[Book]
                                ([Title]
                                    ,[YearOfPublishing]
                                    ,[NumberOfPages]
                                    ,[HardCover]
                                    ,[AuthorID])
                                  VALUES
                                    (@bookName, 2018, 300, 1, 1);
            SELECT CAST(scope_identity() AS int)";

            insertCommand.CommandText = insertText;
            insertCommand.Parameters.Add(bookParameter);

            int Id = (int) insertCommand.ExecuteScalar();

            Console.WriteLine($"Inserted BookID {Id}");
        }
    }
}