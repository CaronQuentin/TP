using Caron.RG.DAL.Model;
using CommandLine;
namespace Caron.RG.CLI
{


    internal class Program
    {
        static void Main(string[] args)
        {
            var db = new CaronDbContext();
            var service = new EspionMissionService(db);

            Parser.Default.ParseArguments<Options>(args)
                .WithParsed(options =>
                {
                    if (options.Import)
                    {
                        if (!string.IsNullOrEmpty(options.Path))
                        {
                            if (File.Exists(options.Path))
                            {
                                string[] informations = File.ReadAllLines(options.Path);

                                foreach (string agent in informations)
                                {
                                    string[] info = agent.Split("; ");

                                    if (info.Length == 2)
                                    {
                                        Espion newEspion = new Espion(info[0], info[1]);
                                        service.AjouterEspion(newEspion);
                                    }
                                    
                                }
                            }  
                        }
                    }
                });
        }
    }
    public class Options
    {
        public bool Import { get; set; }

        [Option('i', "import", HelpText = "Importation des espions :")]

        [Value(0, MetaName = "Path", HelpText = "Chemin du fichier :", Required = false)]

        public string Path { get; set; }


    }
}
