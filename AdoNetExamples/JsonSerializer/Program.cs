using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using JsonSerializer;

namespace ConsoleApplication1
{
    [DataContract]
    public class Dog
    {
        [DataMember(IsRequired = true)]
        public string Name { get; set; }

        [DataMember]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// For some reason you might want the serialized name to look different.
        /// </summary>
        [DataMember(Name = "Tags")]
        public List<String> DistinctiveFeatures { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            LibraryEntities library = new LibraryEntities();


           // var books = library.Books.All(b => b.Price > 10);

            var books2 = from r in library.Books select r;
            var bookslist = books2.ToList();


            //Author a = new Author();
            //a.Name = "Popescu";
            //a.Age = 100;

            //library.Authors.Add(a);

            // library.SaveChanges();


            var dog = new Dog
            {
                Name = "Fluffy",
                BirthDate = DateTime.Now,
                DistinctiveFeatures = new List<string>
                {
                    "black tail",
                    "green eyes"
                }
            };

            var ser = new DataContractJsonSerializer(typeof(Dog));
            var output = string.Empty;

            using (var ms = new MemoryStream())
            {
                ser.WriteObject(ms, dog);
                output = Encoding.UTF8.GetString(ms.ToArray());

                // {"BirthDate":"\/Date(1468591293120+0300)\/","Name":"Fluffy","Tags":["black tail","green eyes"]}
            }

            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(output)))
            {
                var processedDog = (Dog)ser.ReadObject(ms);

                // The two dogs will be the same
            }
        }
    }
}