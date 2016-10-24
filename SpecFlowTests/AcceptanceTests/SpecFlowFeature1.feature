Feature: Logout
	Before Log in Page
	Logout user in page
	I want to the website login


Scenario: Logout User
	Given Before Log in the web site
	| Username | Password |
	| mft | Evor@743 |
	When I press in user name
	And I press logout button
	Then I should be at the login page
