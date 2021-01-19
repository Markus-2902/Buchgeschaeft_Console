using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreLibrary
{
    public class Book : Item
    {
        protected string Author;
        
        protected string Isbn;
        protected Category Categoryy;

        public Book(Category categoryy, string author, string isbn, decimal price, int stock, string title) :base(price, stock, title)
        {
            Categoryy = categoryy;
            Author = author;
            Isbn = isbn;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {Title} ({Author}, {Categoryy} ({(int)Categoryy}))";
        }
    }
}
