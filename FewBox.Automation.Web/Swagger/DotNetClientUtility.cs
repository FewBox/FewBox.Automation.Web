using System;
using System.Threading.Tasks;
using NSwag;
using NSwag.CodeGeneration.CSharp;

namespace FewBox.Automation.Web.Swagger
{
    public static class DotNetClientUtility
    {
        public async static Task<string> GenerateFromUrl(string url, string namespaceName, string className)
        {
            var document = await SwaggerDocument.FromUrlAsync(url);
            var settings = new SwaggerToCSharpClientGeneratorSettings
            {
                ClassName = className, 
                CSharpGeneratorSettings = 
                {
                    Namespace = namespaceName
                }
            };
            var generator = new SwaggerToCSharpClientGenerator(document, settings);	
            return generator.GenerateFile();
        }

        public async static Task<string> GenerateFromFile(string file, string namespaceName, string className)
        {
            var document = await SwaggerDocument.FromFileAsync(file);
            var settings = new SwaggerToCSharpClientGeneratorSettings
            {
                ClassName = className, 
                CSharpGeneratorSettings = 
                {
                    Namespace = namespaceName
                }
            };
            var generator = new SwaggerToCSharpClientGenerator(document, settings);	
            return generator.GenerateFile();
        }

        public async static Task<string> GenerateFromJson(string json, string namespaceName, string className)
        {
            var document = await SwaggerDocument.FromJsonAsync(json);
            var settings = new SwaggerToCSharpClientGeneratorSettings
            {
                ClassName = className, 
                CSharpGeneratorSettings = 
                {
                    Namespace = namespaceName
                }
            };
            var generator = new SwaggerToCSharpClientGenerator(document, settings);	
            return generator.GenerateFile();
        }
    }
}
