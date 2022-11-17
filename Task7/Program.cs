using System;
namespace HW7
{
    interface IFly
    {
        void Flying();
    }

    interface ISwim
    {
        void Swiming();
    }

    interface IJump
    {
        void Jumping();
    }

    interface IGo
    {
        void Going();
    }

    class Program
    {
        static void Main(string[] args)
        {
            // First task
            Console.WriteLine("First task");

            Bird bird = new Bird("Alexandra", "Galliformes", "Female");
            Fish fish = new Fish("Pushok", "Bothriolepis canadensis", "Male");
            Human human = new Human("Pavel", "European", "Male");

            bird.MoveUnit();
            fish.MoveUnit();
            human.MoveUnit();

            // Second task
            Console.WriteLine("\nSecond task");

            MyClass class1 = new MyClass(null);

            Console.WriteLine($"String: {class1.String}");

            // Third task
            Console.WriteLine("\nThird task");

            Libraby libraby = new Libraby();

            try
            {
                Reader reader1 = new Reader("Lion", new Genre[] { Genre.Fantasy, Genre.Drama, Genre.Thriller, Genre.Horror });
                Reader reader2 = new Reader("Pavel", new Genre[] { Genre.Thriller, Genre.Horror });
                Reader reader3 = new Reader("Alex", new Genre[] { Genre.Comedy });
                libraby.AddReader(reader1);
                libraby.AddReader(reader2);
                libraby.AddReader(reader3);
            }
            catch(GenreException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");                
            }

            Book book1 = new Book("cccc", Genre.Comedy);
            Book book2 = new Book("ffff", Genre.Fantasy);
            Book book3 = new Book("dddd", Genre.Drama);
            Book book4 = new Book("tttt", Genre.Thriller);
            Book book5 = new Book("hhhh", Genre.Horror);
            Book book6 = new Book("cccc2", Genre.Comedy);
            libraby.AddBook(book1);
            libraby.AddBook(book2);
            libraby.AddBook(book3);
            libraby.AddBook(book4);
            libraby.AddBook(book5);
            libraby.AddBook(book6);

            libraby.NotifyBooks();
            libraby.ProvideBooks();
        }
    }
}
