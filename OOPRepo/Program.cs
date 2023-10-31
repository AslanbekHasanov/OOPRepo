using OOPRepo;

//Book book = new Book();
////Property orqali private fieldlarga qiymat berish
//book.Name = "Kichkina odam";
//book.Author = "Ulug'bek Meylikov";
//book.Price = 1227000;
//book.SetNewProperty();
//Console.WriteLine("===================");
//book.GetAllInfo();  


//Person classini obyect olgan holda chaqirish
//Person person = new Person();
//person.FirstName = "Test";
//person.LastName = "Test";
//person.Age = 1;

//Person classini obyect olgan holda chaqirish
//Console.WriteLine();
//Person.FirstName = string.Empty;
//Person.LastName = string.Empty;
//Person.Age = 0;
//Person.GetInfo();


//Enum ni chaqirish 

AvtoSalon name = AvtoSalon.Nexia;
int price = (int)AvtoSalon.Gentra;
Array result = Enum.GetValues(typeof(AvtoSalon));

foreach (var item in result)
{
    Console.WriteLine($"{item}");

}


Talaba talaba = new Talaba();
talaba.Id = 1;
talaba.Name = "Allovuddin";

