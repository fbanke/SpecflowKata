﻿using System;
using TechTalk.SpecFlow;
 using Xunit;

 namespace HarryPotter
{
    [Binding]
    public class EstimatePurchaseV2Steps
    {
        private Basket _basket;

        [Scope(Feature = "EstimatePurchaseV2")]
        [Given(@"a basket")]
        public void GivenABasket()
        {
            _basket = new Basket();
        }

        [Scope(Feature = "EstimatePurchaseV2")]
        [When(@"I buy (.*) books")]
        public void WhenIBuyBooks(int nbOfBooks)
        {
            for (var i = 0; i < nbOfBooks; i++)
            {
                _basket.AddBook(new Book { Price = 8 });
            }
        }

        [Scope(Feature = "EstimatePurchaseV2")]
        [Then(@"the total is (.*) €")]
        public void ThenTheTotalIs(double total)
        {
            Assert.Equal(_basket.TotalPrice, total);
        }

        [Scope(Feature = "EstimatePurchaseV2")]
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
