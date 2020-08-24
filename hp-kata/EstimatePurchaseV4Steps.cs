using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Xunit;

namespace HarryPotter
{
    [Binding]
    public class EstimatePurchaseV4Steps
    {
        private Basket _basket;

        [Scope(Feature = "EstimatePurchaseV4")]
        [Given(@"a basket")]
        public void GivenABasket()
        {
            _basket = new Basket();
        }

        [When(@"I buy books")]
        public void WhenIBuyBooks(Table table)
        {
            var books = table.CreateSet<Book>();
            foreach (var book in books)
            {
                _basket.AddBook(book);
            }            
        }


        [Scope(Feature = "EstimatePurchaseV4")]
        [When(@"I buy (.*) books")]
        public void WhenIBuyBooks(int nbOfBooks)
        {
            for (var i = 0; i < nbOfBooks; i++)
            {
                _basket.AddBook(new Book { Price = 8 });
            }
        }

        [Scope(Feature = "EstimatePurchaseV4")]
        [Then(@"the total is (.*) €")]
        public void ThenTheTotalIs(double total)
        {
            Assert.Equal(_basket.TotalPrice, total);
        }

        [Scope(Feature = "EstimatePurchaseV4")]
        [When(@"I buy (.*) book of volume (.*)")]
        public void WhenIBuyBookOfVolume(int nbOfBooks, int volumeNb)
        {
            for (var i = 0; i < nbOfBooks; i++)
            {
                _basket.AddBook(new Book { Price = 8, Volume = volumeNb });
            }
        }
    }
}
