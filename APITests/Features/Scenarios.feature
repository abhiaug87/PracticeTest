Feature: Scenarios for API tests

@Exception
Scenario Outline: Forbidden Access
	Given I have forbidden access to the URL
	When I pass the values for <id> and <key>
	Then I can see the appropriate error message for <id> and <key>
Examples:
| id                | key           |
| qakulkarni@unl.sh | Testmycode123 |