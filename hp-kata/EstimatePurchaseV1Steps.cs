﻿using System;
using TechTalk.SpecFlow;
using Xunit;

 namespace HarryPotter
{
    [Binding]
    public class EstimatePurchaseV1Steps
    {
        private Book _book;

        [Given(@"A book")]
        public void GivenABook()
        {
            _book = new Book {Price = 8};
        }
        
        [Then(@"its price is (.*) €")]
        public void ThenItsPriceIs(int p0)
        {
            Assert.Equal(8, _book.Price);
        }
    }
}
