using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    class Libraby
    {
        List<Book> LBooks = new List<Book>();
        List<Reader> LReader = new List<Reader>();
        public void AddBook(Book book)
        {
            LBooks.Add(book);
        }

        public void AddReader(Reader reader)
        {
            LReader.Add(reader);
        }

        delegate void BookDelegate(Book book);
        event BookDelegate NotifyFantasy;
        event BookDelegate NotifyDrama;
        event BookDelegate NotifyThriller;
        event BookDelegate NotifyHorror;
        event BookDelegate NotifyComedy;

        public void NotifyBooks()
        {
            foreach (Reader reader in LReader)
            {
                foreach (var genre in reader.ChGenres)
                {
                    switch (genre)
                    {
                        case Genre.Fantasy:
                            NotifyFantasy += reader.ShowNewBook;
                            break;
                        case Genre.Drama:
                            NotifyDrama += reader.ShowNewBook;
                            break;
                        case Genre.Thriller:
                            NotifyThriller += reader.ShowNewBook;
                            break;
                        case Genre.Horror:
                            NotifyHorror += reader.ShowNewBook;
                            break;
                        case Genre.Comedy:
                            NotifyComedy += reader.ShowNewBook;
                            break;
                    }
                }
            }
        }

        public void ProvideBooks()
        {
            foreach (Book book in LBooks)
            {

                switch (book.genre)
                {
                    case Genre.Fantasy:
                        if (NotifyFantasy != null)
                            NotifyFantasy(book);
                        break;
                    case Genre.Drama:
                        if (NotifyDrama != null)
                            NotifyDrama(book);
                        break;
                    case Genre.Thriller:
                        if (NotifyThriller != null)
                            NotifyThriller(book);
                        break;
                    case Genre.Horror:
                        if (NotifyHorror != null)
                            NotifyHorror(book);
                        break;
                    case Genre.Comedy:
                        if (NotifyComedy != null)
                            NotifyComedy(book);
                        break;
                }
            }
        }
    }
    enum Genre
    {
        None,
        Fantasy,
        Drama,
        Thriller,
        Horror,
        Comedy
    }

    class Book
    {
        public string Name { get; set; }
        public Genre genre;
        public Book(string name, Genre genre)
        {
            Name = name;
            this.genre = genre;
        }
    }

    class Reader
    {
        public string Name { get; set; }
        public Genre[] ChGenres = new Genre[5];
        public Reader(string name, Genre[] genres)
        {
            int i = 0;
            int res = 0;
            Name = name;
            foreach (Genre genre in genres)
            {
                if (genres.Length <= 5)
                {
                    for (int j = 0; j <= genres.Length - 1; j++)
                    {
                        if (genre == genres[j])
                        {
                            res++;
                        }
                    }
                }
                else
                {
                    throw new GenreException("The specified size of the genres array for the class instance exceeds the allowable size.");
                }

                if (res >= 2)
                {
                    throw new GenreException("Some genres are repetitive.");
                }
                res = 0;

                ChGenres[i] = genre;
                i++;
            }
        }
        public void ShowNewBook(Book book)
        {
            Console.WriteLine($"{Name} should read {book.Name} [{book.genre}]");
        }
        static void ErrChGenres(int res, Genre genre)
        {
            if (genre == Genre.Comedy)
            {
                res++;
            }
        }
    }

    class GenreException : Exception
    {
        public GenreException(string message): base(message)
        { }
    }
}
