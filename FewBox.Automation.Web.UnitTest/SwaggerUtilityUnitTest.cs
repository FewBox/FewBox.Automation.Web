using FewBox.Automation.Web.Swagger;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FewBox.Automation.Web.UnitTest
{
    [TestClass]
    public class SwaggerUtilityUnitTest
    {
        [TestMethod]
        public void TestDotNetClientUtility()
        {
            string code = DotNetClientUtility.GenerateFromFile("./swagger.json", "FewBox", "Kubernetes").Result;
            /*using(var writer = System.IO.File.CreateText("./Kubernetes.cs"))
            {
                writer.Write(code);
                writer.Close();
            }*/
            Assert.IsNotNull(code);
        }
    }
}
