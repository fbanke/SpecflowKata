Feature: EstimatePurchaseV3
	In order to buy harry potter books
	As a customer
	I want to estimate the value of my purchase

@V3
Scenario: Estimate the value of three books of different volumes
	Given a basket
	When I buy 1 book of volume 1
	And I buy 1 book of volume 2
	And I buy 1 book of volume 3
	Then the total is 21.6 €

@V3
Scenario: Estimate the value of four books of different volumes
	Given a basket
	When I buy 1 book of volume 1
	And I buy 1 book of volume 2
	And I buy 1 book of volume 3
	And I buy 1 book of volume 4
	Then the total is 27.2 €

@V3
Scenario: Estimate the value of five books of different volumes
	Given a basket
	When I buy 1 book of volume 1
	And I buy 1 book of volume 2
	And I buy 1 book of volume 3
	And I buy 1 book of volume 4
	And I buy 1 book of volume 5
	Then the total is 32 €