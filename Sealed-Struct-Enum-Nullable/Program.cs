

using Sealed_Struct_Enum_Nullable;

//Book book = new Book();
//book.Name = "saiksdlajd";
//Console.WriteLine(book.Name);



//Class1 class1 = new Class1();
//class1.MyProperty = 1010;
//Console.WriteLine(class1.MyProperty);






string name = null;
//Console.WriteLine(name);





//Book book = new Book();
//Console.WriteLine(book.Id);


//if(book.Id == null)
//{
//    Console.WriteLine("Book id is notfound");
//}





Book book1 = new Book()
{
    Id = 1,
    Name = "Isgendername",
    Author = new Author() { Name = "Nizami", Id = 2 }
};






Book book2 = new Book()
{
    Id = 2,
    Name = "Xosrov ve Shirin"
};






//Console.WriteLine("Book: " + book1.Name + "   Author: " + book1.Author.Name);

//Console.WriteLine("Book: " + book2.Name + "   Author: " + book2.Author?.Name);




//Book[] books = { book1, book2 };


//void  GetBookById(int? id)
//{
//    Console.WriteLine(id == null);
//}

//GetBookById(null);
//GetBookById(1);







void GetBookById(Book[] books, int? id = null)
{
    if (id == null)
    {
        Console.WriteLine("Your id is null");
        return;
    }

    var result = books.FirstOrDefault(m => m.Id ==/*(int)*/ id);
    Console.WriteLine(result.Name);
}

////GetBookById(books);
////GetBookById(books,5);
//GetBookById(books,2);








//Level level = Level.Low;

//Console.WriteLine(level);

//Console.WriteLine((int)level == 1);

//Console.WriteLine();





//void GetLevel(int levelNum)
//{
//    switch (levelNum)
//    {
//        case (int)Level.Low:
//            Console.WriteLine("Low");
//            break;
//        case (int)Level.Medium:
//            Console.WriteLine("Medium");
//            break;
//        case (int)Level.High:
//            Console.WriteLine("High");
//            break;
//    }
//}


//GetLevel(2);








void GetLevel(string level)
{
    switch (level)
    {
        case nameof(Level.Low):
            Console.WriteLine("Low");
            break;
        case nameof(Level.Medium):
            Console.WriteLine("Medium");
            break;
        case nameof(Level.High):
            Console.WriteLine("High");
            break;
    }
}


//GetLevel("Low");
//GetLevel("Medium");
//GetLevel("High");
