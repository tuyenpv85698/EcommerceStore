using System.Threading.Tasks;
using EcommerceStore.Models.TokenAuth;
using EcommerceStore.Web.Controllers;
using Shouldly;
using Xunit;

namespace EcommerceStore.Web.Tests.Controllers
{
    public class HomeController_Tests: EcommerceStoreWebTestBase
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