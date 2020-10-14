
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento // bir hafiza olusturmak ve o hafizayi geri dönüşü anlatır
{
    class Program
    {
        public static string Titel { get; private set; }

        static void Main(string[] args)
        {
            Book book = new Book
            {
           
                Isbn="12345",
                Author="Basil avad",
                Titel="Sefiller "

            };
            book.ShowBook();


            CareTaker history = new CareTaker();
            history.memento = book.Createundo();
            book.Isbn = "33565";
                book.Titel = "kjgkjklfnb";
            book.ShowBook();

            book.RestorFromUndo(history.memento);
            book.ShowBook();
            Console.ReadLine();
        }
    }
    class Book
    {
        DateTime _lastEdited;
        private string _titel;

       public string Titel
        {
            get { return _titel; }
            set { _titel = value; }
        }

        private string _author;

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        

        private string _ısbn;

        public string Isbn
        {
            get { return _ısbn; }
            set { _ısbn = value; }
        }

        //public void SetIsbn(string value)
        //{
        //    _ısbn = value;
        //    SetLastEdited();  // bu nesnenin değiştiği bana isbat edecek 
        //}
        private void SetLastEdited()
        {
            _lastEdited = DateTime.UtcNow;
        }
        public Memento Createundo()
        {
            return new Memento(_author, _ısbn, _titel, _lastEdited);
        }

        public void RestorFromUndo(Memento memento)
        {
            _ısbn = memento.Isbn;
            _author = memento.Auther;
            _titel = memento.Titel;
            _lastEdited = memento.LastEdited;
        }
        public void ShowBook()
        {
            Console.WriteLine("{0},{1},{2} edited :{3} ",_ısbn,_author,_titel,_lastEdited);
        }
    }

    // Memento hafiza 
    class Memento
    {
        public string Titel { get; set; }
        public string Isbn { get; set; }
        public string Auther { get; set; }
        public DateTime LastEdited { get; set; }


        public Memento(string titel, string isbn,string auther,DateTime lastedited)
        {
            Isbn = isbn;
            Titel = titel;
            Auther = auther;
            LastEdited = lastedited;
        }
    }
    class CareTaker
    {
        public Memento memento { get; set; }
    }


}
