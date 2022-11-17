using System;
namespace less4
{
    interface IMusic
    {
        string Сharacteristics { get; set; }
        void PlaySound();
    }

    interface IPrintable
    {
        void Print();
    }

    class Program
    {
        static void Main(string[] args)
        {
            // First task
            var instruments = new List<IMusic>();
            Guitar guitar1 = new Guitar("model 1", "perfect characteristic", 600);
            Guitar guitar2 = new Guitar("model 2", "good characteristic", 99);
            Guitar guitar3 = new Guitar("model 3", "low characteristic", 111);

            Drums drum1 = new Drums("model 1", "perfect characteristic", 900);
            Drums drum2 = new Drums("model 2", "good characteristic", 99);
            Drums drum3 = new Drums("model 3", "low characteristic", 555);

            Piano piano1 = new Piano("model 1", "perfect characteristic", 1200);
            Piano piano2 = new Piano("model 2", "good characteristic", 99);
            Piano piano3 = new Piano("model 3", "low characteristic", 777);

            instruments.AddRange(new List<IMusic>() { guitar1, guitar2, guitar3, drum1, drum2, drum3, piano1, piano2, piano3});

            foreach (var instr in instruments)
            {
                instr.PlaySound();
            }

            //Second task
            Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald");
            Book book2 = new Book("One Hundred Years of Solitude", "Gabriel Garcia Marquez");
            Book book3 = new Book("Ulysses", "James Joyce");

            Magazine magazine1 = new Magazine("AARP The Magazine", "Nature America");
            Magazine magazine2 = new Magazine("AARP Bulletin", "Nature America");
            Magazine magazine3 = new Magazine("Costco Connection", "Nature America");

            IPrintable[] mas = new IPrintable[6] { book1, magazine1, book3, magazine3, book2, magazine2 };

            foreach (IPrintable element in mas)
            {
                element.Print();
            }

            Book.PrintBooks(mas);
            Magazine.PrintMagazine(mas);
        }
    }

    
}
