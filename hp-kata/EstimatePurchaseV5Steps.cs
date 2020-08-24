﻿using System;
using TechTalk.SpecFlow;
 using Xunit;

 namespace HarryPotter
{
    [Binding]
    public class EstimatePurchaseV5Steps
    {
        private Basket _basket;

        [Scope(Feature = "EstimatePurchaseV5")]
        [Given(@"a basket")]
        public void GivenABasket()
        {
            _basket = new Basket();
        }

        [Scope(Feature = "EstimatePurchaseV5")]
        [When(@"I bought (.*) books of volume (.*)")]
        public void WhenIBoughtBooksOfVolume(int nbOfBooks, int volumeNumber)
        {
            for (var i = 0; i < nbOfBooks; i++)
            {
                _basket.AddBook(new Book { Price = 8, Volume = volumeNumber});
            }
        }

        [Then(@"the total is (.*) euro")]
        public void ThenTheTotalIs(double p0)
        {
            Assert.Equal(_basket.TotalPrice, p0);
        }

    }
}
