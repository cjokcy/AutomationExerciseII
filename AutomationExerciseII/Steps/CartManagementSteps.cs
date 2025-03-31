using AutomationExerciseII.Drivers;
using AutomationExerciseII.Page;


namespace AutomationExerciseII.Steps
{
    [Binding]
    public sealed class CartManagementSteps
    {

        readonly DriverHelper _driverHelper;
        readonly HomePage homePage;
        readonly LoginPage loginPage;

        public CartManagementSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            homePage = new HomePage(_driverHelper.Driver);
            loginPage = new LoginPage(_driverHelper.Driver);
        }


        [When("the user clicks adds two products to cart")]
        public void WhenTheUserClicksAddsTwoProductsToCart()
        {
            homePage.AddProductToCart();
            homePage.AddProductToCart();
        }

        [Then("the user verify prices, quantity, and total")]
        public void ThenTheUserVerifyPricesQuantityAndTotal()
        {
            homePage.ClickToViewTheCart();

            Assert.IsTrue(homePage.IsProductPricesAsExpected());
            
            Assert.IsTrue(homePage.IsProductQuantityAsExpected());
            
            Assert.IsTrue(homePage.IsTotalAsExpected());
        }

    }
}
