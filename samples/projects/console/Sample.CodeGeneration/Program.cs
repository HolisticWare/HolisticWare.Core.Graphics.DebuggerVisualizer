using NJsonSchema.CodeGeneration.CSharp;

namespace Sample.Original
{
    class Program
    {
        static void Main(string[] args)
        {
            string json = System.IO.File.ReadAllText("Schema.json");
            var schemaFromFile = NJsonSchema.JsonSchema.FromSampleJson(json);
            var classGenerator = new NJsonSchema.CodeGeneration.CSharp.CSharpGenerator
                                                                            (
                                                                                schemaFromFile,
                                                                                new CSharpGeneratorSettings
                                                                                {
                                                                                    ClassStyle = CSharpClassStyle.Poco,
                                                                                }
                                                                            );
            var codeFile = classGenerator.GenerateFile();
            System.IO.File.WriteAllText("Schema.cs", codeFile);
        }
    }
}
