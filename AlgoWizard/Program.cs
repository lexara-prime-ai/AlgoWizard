using CommandLine;
using System.Text.Json;
using AlgoWizardCLI.Model;

namespace AlgoWizardCLI 
{
    class Program {
        public class Options
        {
            [Option('g', "generate", Required = false, HelpText = "Generate algorithm")]
            public bool Algorithm { get; set; }
        }

        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                .WithParsed<Options>(o =>
                {
                    if (o.Algorithm)
                    {
                        HttpClient client = new HttpClient();
                        
                    }
                });
        }
    }
}