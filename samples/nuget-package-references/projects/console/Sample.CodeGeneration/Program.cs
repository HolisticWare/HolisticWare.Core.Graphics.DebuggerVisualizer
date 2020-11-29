using NJsonSchema.CodeGeneration.CSharp;

namespace Sample.Original
{
    class Program
    {
        static void Main(string[] args)
        {
            string json = null;
            NJsonSchema.JsonSchema schemaFromFile = null;
            CSharpGenerator classGenerator = null;
            string codeFile = null;

            json = System.IO.File.ReadAllText("Schema.json");
            schemaFromFile = NJsonSchema.JsonSchema.FromSampleJson(json);
            classGenerator = new NJsonSchema.CodeGeneration.CSharp.CSharpGenerator
                                                                            (
                                                                                schemaFromFile,
                                                                                new CSharpGeneratorSettings
                                                                                {
                                                                                    ClassStyle = CSharpClassStyle.Poco,
                                                                                }
                                                                            );
            codeFile = classGenerator.GenerateFile();
            System.IO.File.WriteAllText("Schema.cs", codeFile);


            json = System.IO.File.ReadAllText("Schema.1.json");
            schemaFromFile = NJsonSchema.JsonSchema.FromSampleJson(json);
            classGenerator = new NJsonSchema.CodeGeneration.CSharp.CSharpGenerator
                                                                            (
                                                                                schemaFromFile,
                                                                                new CSharpGeneratorSettings
                                                                                {
                                                                                    ClassStyle = CSharpClassStyle.Poco,
                                                                                }
                                                                            );
            codeFile = classGenerator.GenerateFile();
            System.IO.File.WriteAllText("Schema.1.cs", codeFile);




            json = System.IO.File.ReadAllText("Schema.2.json");
            schemaFromFile = NJsonSchema.JsonSchema.FromSampleJson(json);
            classGenerator = new NJsonSchema.CodeGeneration.CSharp.CSharpGenerator
                                                                            (
                                                                                schemaFromFile,
                                                                                new CSharpGeneratorSettings
                                                                                {
                                                                                    ClassStyle = CSharpClassStyle.Poco,
                                                                                }
                                                                            );
            codeFile = classGenerator.GenerateFile();
            System.IO.File.WriteAllText("Schema.2.cs", codeFile);

            return;
        }
    }
}
