using System.Collections.Generic;
using System.Linq;

namespace HarryPotter
{
    internal class BookSet
    {
        private List<Book> _books = new List<Book>();
        private DiscountCatalog _discounts = new DiscountCatalog();

        public bool Contains(Book book)
        {
            return _books.Exists(x => x.Volume == book.Volume);
        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public double Price
        {
            get
            {
                var discount = _discounts.GetDiscount(_books.Count);
                return _books.Sum(x => x.Price) * discount;
            }
        }
    }
}