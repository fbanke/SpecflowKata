Feature: EstimatePurchaseV1
	In order to buy harry potter books
	As a customer
	I want to estimate the value of my purchase

@V1
Scenario: Validate the value of one book
	Given A book	
	Then its price is 8 €
	