Feature: Scenarios for inventory management system

@Chrome
@Basic
Scenario: Login to Inventory
	Given I am on the login page
    When I enter login credentials to get access to the portal
	Then I am redirected to the dashboard page

@Chrome
@Basic
Scenario: Add a Product
    Given I am on the Add Product page
	When I add details of the product
	And save the product
	Then I see a confirmation message

@Chrome
@Basic
Scenario: Complete sales flow
    Given I am on the sales order page
	When I add sales order
	And view the product ordered
	Then I see the availability details


@Chrome
@Basic
Scenario: Login and change name
    Given I am on the main page
	When I click login
	And I click on Profile
	Then I see the changes

@Chrome
@Basic
Scenario: Login and Create XS Product in SX
    Given I am on the Sub External page
	And I create a billing account
	And I login to SX
	And I can see the Billing Account of my org

@Chrome
@Basic
Scenario: Assert Product App Catalogue Page
    Given I am on the Product App page
	When I login to the app
	Then I am able to see the rows:
	| Name          | Purchasable Type | Partner Only |
	| Apple         | Never            |              |
	| Demo Regular  | Never            |              |
	| Learn         | Never            |              |
	| Practice      | Never            |              |
	| Premium       | Always           |              |
	| Standard      | Always           |              |
	| Starter       | Always           |              |
	| Trial         | Never            |              |



