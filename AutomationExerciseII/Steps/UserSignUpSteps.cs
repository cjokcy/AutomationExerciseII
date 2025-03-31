using AutomationExerciseII.Drivers;
using AutomationExerciseII.Page;
using Reqnroll.Assist.Dynamic;

namespace AutomationExerciseII.Steps
{
    [Binding]
    public sealed class UserSignUpSteps
    {
        readonly DriverHelper _driverHelper;
        private HomePage homePage;
        private SignUpPage signUpPage;
        private LoginPage loginPage;
        

        public UserSignUpSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            homePage = new HomePage(_driverHelper.Driver);
            loginPage = new LoginPage(_driverHelper.Driver);
            signUpPage = new SignUpPage(_driverHelper.Driver);
        }

        #region StepActions
        [Given(@"the user navigates to the ""(.*)""")]
        public void GivenTheUserNavigatesToThe(string url)
        {
            _driverHelper.Driver.Navigate().GoToUrl(url);
            signUpPage.AcceptConsent();
            Assert.IsTrue(signUpPage.HomePageIsVisible());
        }

        [When("the user clicks on the signup\\/login link")]
        public void WhenTheUserClicksOnTheSignupLoginLink()
        {       
            signUpPage.ClickSignUpButton();
            Assert.IsTrue(signUpPage.NewUserSignupIsVisible());
        }

                
        [When("the user enters valid details on the signup form")]
        public void WhenTheUserEntersValidDetailsOnTheSignupForm(DataTable data)
        {
            // Create a dynamic set from the DataTable
            dynamic details = data.CreateDynamicInstance();
            signUpPage.EnterSignUpDetails(data.Rows[0]["name"], data.Rows[0]["email"]);
        }

        [When("the user clicks on the {string} button")]
        public void WhenTheUserClicksOnTheButton(string button)
        {
            if (button.Equals("signup", StringComparison.CurrentCultureIgnoreCase))
            {
                signUpPage.ClickSignUpButtonForNewUser();
            }
            else if (button.Equals("create account", StringComparison.CurrentCultureIgnoreCase))
            {
                signUpPage.ClickCreateAccount();
            }
            else if (button.Equals("delete account", StringComparison.CurrentCultureIgnoreCase))
            {
                signUpPage.DeleteAccount();
            }
            else if (button.Equals("continue", StringComparison.CurrentCultureIgnoreCase))
            {
                signUpPage.ClickContinue();
            }
            else if (button.Equals("login", StringComparison.CurrentCultureIgnoreCase))
            {
                loginPage.ClickLogin();
            }
            else if (button.Equals("email address already exist!", StringComparison.CurrentCultureIgnoreCase))
            {
                loginPage.ClickLogin();
            }
        }

        [Then("{string} should be visible")]
        public void ThenShouldBeVisible(string message)
        {
            switch (message)
            {
                case "ENTER ACCOUNT INFORMATION":
                    Assert.IsTrue(signUpPage.IsAccountInformationMessageDisplayed());
                    break;

                case "ACCOUNT CREATED!":
                    Assert.IsTrue(signUpPage.IsAccountCreatedMessageDisplayed());
                    break;
                case "Logged in as Test Test":
                    Assert.IsTrue(signUpPage.IsLoggedInUserDisplayed());
                    break;
                case "ACCOUNT DELETED!":
                    Assert.IsTrue(signUpPage.IsAccountDeletedMessageDisplayed());
                    break;
                case "Login to your account":
                    Assert.IsTrue(loginPage.IsLoginToYourAccountMessageDisplayed());
                    break;
                case "Email Address already exist!":
                    Assert.IsTrue(signUpPage.IsEmailAlreadyExistMessageDisplayed());
                    break;
                default:
                    Console.WriteLine("Message is unknown");
                    break;
            }
            
        }

        [When("I fill in the address details:")]
        public void WhenIFillInTheAddressDetails(Table table)
        {
            var data = table.Rows[0];
            signUpPage.EnterRegistrationDetails(
                data["First Name"], data["Last Name"], data["Company"], data["Address"],
                data["Address2"], data["Country"], data["State"], data["City"],
                data["Zip code"], data["Mobile Number"], data["Password"], data["DOB"]);
        }
        #endregion
    }
}
