using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCodeSnippets.Deployment.Code
{
    public class MyCodeSnippetsDeployment
    {
        static int Main(string[] args)
        {
            var snippetFiles = Directory.GetFiles("Snippets","*.snippet");
            string destPathMyDoc= Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string destPath = Path.Combine(destPathMyDoc, @"Visual Studio 2012\Code Snippets\Visual C#\My Code Snippets");
            foreach (var file in snippetFiles)
            {
                try
                {
                    string dest = Path.Combine(destPath, Path.GetFileName(file));
                    File.Copy(file, dest,true);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error:"+ex.Message);
                }
            }
            Console.WriteLine("Done");
            Console.ReadKey();
            return 0;
        }

    }
}
