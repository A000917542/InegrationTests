

//using IntegrationTests.WebApp1.Controllers;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Filters;
//using Microsoft.Extensions.Logging;

//namespace IntegrationTests.WebApp1.Tests
//{
//    [TestClass]
//    public class IntegrationTestRedux
//    {
//        [TestMethod]
//        public void Method1()
//        {
//            var home = new HomeController();
//            var result = home.Index();
//            var logger = new Logger<HomeController>(LoggerFactory.Create());

//            var ctx = new ActionContext();
//            if (result != null)
//            {
//                result.ExecuteResultAsync(ctx);
//                var bdy = home.Response.Body.ToString();

//                int x = 5;
//            }
//        }
//    }
//}
