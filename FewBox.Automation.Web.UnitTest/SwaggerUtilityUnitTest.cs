using System.IO;
using FewBox.Automation.Web.Swagger;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FewBox.Automation.Web.UnitTest
{
    [TestClass]
    public class SwaggerUtilityUnitTest
    {
        [TestMethod]
        public void TestFromFile()
        {
            string code = DotNetClientUtility.GenerateFromFile("./swagger.json", "FewBox", "Kubernetes").Result;
            /*using(var writer = System.IO.File.CreateText("./Kubernetes.cs"))
            {
                writer.Write(code);
                writer.Close();
            }*/
            Assert.IsNotNull(code);
        }

        [TestMethod]
        public void TestFromData()
        {
            string data = File.ReadAllText("./swaggerData.json");
            string code = DotNetClientUtility.GenerateFromJson(data, "FewBox", "Kubernetes").Result;
            Assert.IsNotNull(code);
        }

        [TestMethod]
        public void TestFromUrl()
        {
            string url = "https://raw.githubusercontent.com/kubernetes/kubernetes/master/api/openapi-spec/swagger.json";
            string code = DotNetClientUtility.GenerateFromUrl(url, "FewBox", "Kubernetes").Result;
            Assert.IsNotNull(code);
        }
    }
}
