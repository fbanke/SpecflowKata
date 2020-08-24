Feature: EstimatePurchaseV5
	In order to buy harry potter books
	As a customer
	I want to estimate the value of my purchase


@V5
Scenario Outline: Estimate different purchase scenarios
	Given a basket
	When I bought <nbOfBooks_1> books of volume 1
	And I bought <nbOfBooks_2> books of volume 2
	And I bought <nbOfBooks_3> books of volume 3
	And I bought <nbOfBooks_4> books of volume 4
	And I bought <nbOfBooks_5> books of volume 5
	Then the total is <totalPrice> euro

	Examples:
	| nbOfBooks_1 | nbOfBooks_2 | nbOfBooks_3 | nbOfBooks_4 | nbOfBooks_5 | totalPrice |
	| 1           | 0           | 0           | 0           | 0           | 8.0		   |
	| 1           | 1           | 0           | 0           | 0           | 15.2       |
	
