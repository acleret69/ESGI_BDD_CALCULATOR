Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator]($projectname$/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Add numbers
	Given add number is 50
	And add number is 70
	And add number is 30
	When the two numbers are added
	Then the result should be 150

Scenario: Soustact numbers
	Given add number is 70
	And add number is 50
	And add number is 10
	When the two numbers are soustacted
	Then the result should be 10
	
Scenario: Multiplie numbers
	Given add number is 5
	And add number is 7
	And add number is 2
	When the two numbers are multiplied
	Then the result should be 70
	
Scenario: Divise numbers
	Given add number is 50
	And add number is 5
	And add number is 2
	When the two numbers are divised
	Then the result should be 5
	
Scenario: Divise O 
	Given add number is 25
	And add number is 0
	When the two numbers are divised
	Then the error 'error impossible divised with 0' should be raised
	
Scenario: Multiple opération
	Given add number is 5
	And add operante is +
	And add number is 7
	And add operante is -
	And add number is 2
	And add operante is *
	And add number is 2
	And add operante is /
	And add number is 4
	When the end opérations
	Then the result should be 5
	
Scenario: Multiple opération divison 0
	Given add number is 5
	And add operante is +
	And add number is 7
	And add operante is -
	And add number is 2
	And add operante is *
	And add number is 2
	And add operante is /
	And add number is 0
	When the end opérations
	Then the error 'error impossible divised with 0' should be raised
	
