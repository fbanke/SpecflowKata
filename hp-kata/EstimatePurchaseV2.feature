Feature: EstimatePurchaseV2
	In order to buy harry potter books
	As a customer
	I want to estimate the value of my purchase

@V2
Scenario: Estimate the value of two books of same volume
	Given a basket
	When I buy 2 books
	Then the total is 16 €	
@V2
Scenario: Estimate the value of two books of different volumes
	Given a basket
	When I buy 1 book of volume 1
	And I buy 1 book of volume 2
	Then the total is 15.2 €
@V2
Scenario: Estimate the value of three books of different volumes
	Given a basket
	When I buy 1 book of volume 1
	And I buy 1 book of volume 2
	And I buy 1 book of volume 3
	Then the total is 21.6 €