Feature: B_Login

#Background: 
      

 Scenario Outline: TestCase2_User logs in with valid credentials and deletes account
    Given the user navigates to the "https://automationexercise.com"
    Then "Home" should be visible
    When the user clicks on the signup/login link
    Then "Login to your account" should be visible
    And the user enter correct email address "<email>" and password "<password>"
    When the user clicks on the "Login" button
    Then "Logged in as test test" should be visible 
    When the user clicks on the "Delete Account" button
    Then "ACCOUNT DELETED!" should be visible

  Examples:
    | url                           | email            | password    | username  |
    | http://automationexercise.com | aem002@test.com  | password123 | test test |