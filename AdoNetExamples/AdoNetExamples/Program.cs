using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Serialization;

namespace AdoNetExamples
{
    internal class Program
    {
        public static void Save(string FileName)
        {
            Author a1 = new Author();
            a1.Age = 10;
            a1.Name = "Ionescu";

            List<Author> list = new List<Author>();
            list.Add(a1);
            list.Add(new Author
            {
                Age = 15
            });

            using (var writer = new System.IO.StreamWriter(FileName))
            {
                var serializer = new XmlSerializer(list.GetType());
                serializer.Serialize(writer, list);
                writer.Flush();
            }
        }

        public static List<Author> Load(string FileName)
        {
            using (var stream = System.IO.File.OpenRead(FileName))
            {
                var serializer = new XmlSerializer(typeof(List<Author>));
                return serializer.Deserialize(stream) as List<Author>;
            }
        }

        private static void Main(string[] args)
        {
            Save("Test.txt");

            List<Author> a = Load("Test.txt");

            //string connectionString = "Data Source=.;Initial Catalog=Library;Integrated Security=True";
            // string connectionString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"];

            int age = int.Parse(System.Configuration.ConfigurationManager.AppSettings["Age"]);
            string connectionString =
                System.Configuration.ConfigurationManager.ConnectionStrings["LibraryDatabaseConnection"].ConnectionString;

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

            using (SqlDataReader reader = selectCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    string book = $"{reader["Id"]}, {reader[1]}";
                    Console.WriteLine(book);
                }

                reader.Close();
            }

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