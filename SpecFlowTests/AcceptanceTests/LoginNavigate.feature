Feature: Login
  In order to access my account
  As a user of the website
  I want to log into the website

Scenario: Some Logging in with valid credentials
  Given I am at the login page
  When I fill in the following form
  | Username | Password |
  | mft | Evor@743 |
  And I click the login button
  Then I should be at the home page

