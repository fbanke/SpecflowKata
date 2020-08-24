using System.Collections.Generic;
using System.Linq;

namespace HarryPotter
{
    public class Basket
    {
        readonly List<BookSet> _bookSets = new List<BookSet>();
        public void AddBook(Book book)
        {
            var availableBookSet = _bookSets.FirstOrDefault(x => !x.Contains(book));
            if (availableBookSet != null)
                availableBookSet.AddBook(book);
            else
            {
                var newBookSet = new BookSet();
                newBookSet.AddBook(book);
                _bookSets.Add(newBookSet);
            }
        }

        public double TotalPrice => EstimateBasket();

        private double EstimateBasket()
        {
            return _bookSets.Sum(x => x.Price);
        }
    }
}