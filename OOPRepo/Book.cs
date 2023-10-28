using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPRepo
{
    public class Book
    {
        //feild => maydon
        private string name = "No name";
        private string author = "No author";
        private decimal price = 0;

        //property => xususiyat
        public string Name 
        {
            get
            {
                return name;
            }
            set 
            {
                name = value;
            }
        }
        public string Author 
        {
            get
            {
                return author;
            }
            set 
            {
                author = value;
            } 
        }

        public decimal Price {
            get
            {
                return price;
            }
            set 
            {
                price = value;
            }
        }
        public string Edition { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }

        public Book()
        {
            
        }

        public Book(string Name)
        {
            this.Name = Name;
        }

        //bu usul orqali biz Name prop qiymatini olamiz
        public void GetName()
        {
            Console.WriteLine($"Name: {this.Name}");
        }

        //method new for prop
        public void SetNewProperty()
        {
            Console.Write("Edition: ");
            Edition = Console.ReadLine();
            Console.Write("Description: ");
            Description = Console.ReadLine();
            Console.Write("Type: ");
            Type = Console.ReadLine();
        }
        //Aded Method GetAllIfo()
        public void GetAllInfo()
        {
            Console.WriteLine($"Name: {Name}\n" +
                $"Author: {Author}\n" +
                $"Price: {Price}\n" +
                $"Edition: {Edition}\n" +
                $"Description: {Description}\n" +
                $"Type: {Type}");
        }


    }

}
