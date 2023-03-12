Feature: Tmfeature

As a turnup portal admin I would like to create, edit Time and materials Records

@tag1
Scenario: Create Time and Material Record with valid details
	Given I logged into Turnup Portal
	When I navigate to Time and Material Page
	And I create a new Time and Material Record
	Then The record should be successfully created

	Scenario Outline: Edit existing time and Material record
	Given I logged into Turnup Portal
	When I navigate to Time and Material Page
	And I update '<Description>' on an existing time and material record
	Then The record should have the updtaed '<Description>'


	Examples: 
	| Description   |
	| time          |
	| material      |
	| Edited Record |







