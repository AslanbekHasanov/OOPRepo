using OOPRepo;

Book book = new Book();
//Property orqali private fieldlarga qiymat berish
book.Name = "Kichkina odam";
book.Author = "Ulug'bek Meylikov";
book.Price = 1227000;
book.SetNewProperty();
Console.WriteLine("===================");
book.GetAllInfo();  