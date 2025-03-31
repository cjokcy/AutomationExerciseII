Feature: A_User SignUp

A short summary of the feature


 @Smoke
Scenario: TestCase1_User registers and deletes an account 
    Given the user navigates to the "https://automationexercise.com"
    When the user clicks on the signup/login link
    And the user enters valid details on the signup form
    | name      | email           |
    | Test Test | aem002@test.com |
    And the user clicks on the "Signup" button
    Then "ENTER ACCOUNT INFORMATION" should be visible
    When I fill in the address details:
      | First Name | Last Name | Company     | Address    | Address2 | Country | State | City     | Zip code | Mobile Number | Password    | DOB             |
      | Test       | Test      | Testing ltd | 123 Street | Apt 4B   | USA     | NY    | New York | 10001    | 1404111111    | password123 | 31, March, 1990 |
    And the user clicks on the "Create Account" button
    Then "ACCOUNT CREATED!" should be visible
    When the user clicks on the "Continue" button
    Then "Logged in as Test Test" should be visible
    #When the user clicks on the "Delete Account" button
    #Then "ACCOUNT DELETED!" should be visible



 Scenario: TestCase5_User attempts to register with an already existing email
    Given the user navigates to the "https://automationexercise.com"
    When the user clicks on the signup/login link
    And the user enters valid details on the signup form
    | name      | email           |
    | Test Test | aem001@test.com |
    And the user clicks on the "Signup" button
    Then "Email Address already exist!" should be visible

  