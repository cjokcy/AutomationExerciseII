using AutomationExerciseII.Drivers;
using AutomationExerciseII.Page;
using Reqnroll;
using TechTalk.SpecFlow.Assist;

namespace AutomationExerciseII.Steps
{
    [Binding]
    public sealed class LoginSteps
    {

        readonly DriverHelper _driverHelper;
        readonly HomePage homePage;
        readonly LoginPage loginPage;

        public LoginSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            homePage = new HomePage(_driverHelper.Driver);
            loginPage = new LoginPage(_driverHelper.Driver);
        }

        #region StepActions
        [Then("the user enter correct email address {string} and password {string}")]
        public void ThenTheUserEnterCorrectEmailAddressAndPassword(string user, string pass)
        {
            loginPage.EnterUserNameAndPassword(user, pass);
        }
        #endregion
    }
}
