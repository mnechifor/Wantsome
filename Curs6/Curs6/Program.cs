using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs6
{
    class Program
    {
        static void Main(string[] args)
        {
            Author a1 = new Author("Misu");
            a1.BirthDate = new DateTime(1980, 10, 10);
            a1.Email = "email";
            var varsta = a1.ComputeAge();
            Console.WriteLine($"Varsta lui {a1.Name} este:{varsta}");


            Author a2 = new Author("Ionescu");
            a2.BirthDate = new DateTime(2000, 10, 10);
            var varstaIonescu = a2.ComputeAge();
            
            Console.ReadLine();
        }
    }

    public class Author
    {
        public Author(Author author)
        {
            this.Name = author.Name;
            this.BirthDate = author.BirthDate;
        }
        public Author(string name)
        {
            this.Name = name;
        }

        public Author()
        {

        }

        private string email;

        public void SetEmail(string val)
        {
            this.email = val;
        }
        public string Email
        {
            get
            {
                return email;
            }
            set { email = value; }
        }


        public string Name { get; }

        public string GetEmail()
        {
            return this.email;
        }

        public string Country;

        public DateTime BirthDate;

        public int ComputeAge()
        {
            int age = DateTime.Now.Year - this.BirthDate.Year;

            return age;
        }

        public double ComputeAge(DateTime date)
        {
            int age = date.Year - this.BirthDate.Year;

            return age;
        }

        public int ComputeAge(int year)
        {
            int age = year - this.BirthDate.Year;

            return age;
        }
    }
}
