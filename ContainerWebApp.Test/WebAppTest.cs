using ContainerWebApp.Pages;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace ContainerWebApp.Test
{
    public class WebAppTest
    {
        [Fact]
        public void Test1()
        {
            Assert.Empty(new List<string>());
        }

        //[Fact]

        //public async Task Test_Result_From_Index_Model()
        //{
        //    // Arrange
        //    var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>()
        //        .UseInMemoryDatabase("InMemoryDb");
        //    var mockAppDbContext = new Mock<AppDbContext>(optionsBuilder.Options);
        //    var expectedMessages = AppDbContext.GetSeedingMessages();            
        //    var httpContext = new DefaultHttpContext();
        //    var modelState = new ModelStateDictionary();
        //    var actionContext = new ActionContext(httpContext, new RouteData(), new PageActionDescriptor(), modelState);
        //    var modelMetadataProvider = new EmptyModelMetadataProvider();
        //    var viewData = new ViewDataDictionary(modelMetadataProvider, modelState);
        //    var tempData = new TempDataDictionary(httpContext, Mock.Of<ITempDataProvider>());
        //    var pageContext = new PageContext(actionContext)
        //    {
        //        ViewData = viewData
        //    };
        //    var pageModel = new IndexModel()
        //    {
        //        PageContext = pageContext,
        //        TempData = tempData,
        //        Url = new UrlHelper(actionContext)
        //    };
        //    pageModel.ModelState.AddModelError("Message.Text", "The Text field is required.");

        //    // Act
        //    var result = await pageModel.OnPostAddMessageAsync();

        //    // Assert
        //    Assert.IsType<int>(result);
        //}
    }
}
