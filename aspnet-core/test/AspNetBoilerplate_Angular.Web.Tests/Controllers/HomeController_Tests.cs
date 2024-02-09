using System.Threading.Tasks;
using AspNetBoilerplate_Angular.Models.TokenAuth;
using AspNetBoilerplate_Angular.Web.Controllers;
using Shouldly;
using Xunit;

namespace AspNetBoilerplate_Angular.Web.Tests.Controllers
{
    public class HomeController_Tests: AspNetBoilerplate_AngularWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}