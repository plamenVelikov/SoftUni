namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            SortedDictionary<string, List<FileInfo>> extentionsFiles = new SortedDictionary<string, List<FileInfo>>();
            string[] files = Directory.GetFiles(inputFolderPath);
            foreach (var file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                if (!extentionsFiles.ContainsKey(fileInfo.Extension))
                {
                    extentionsFiles.Add(fileInfo.Extension, new List<FileInfo>());
                }
                
                extentionsFiles[fileInfo.Extension].Add(fileInfo);
            }
            var ordExtentionFiles = extentionsFiles.OrderByDescending(ef => ef.Value.Count);

            StringBuilder sb = new StringBuilder();

            foreach (var ef in ordExtentionFiles)
            {
                sb.AppendLine(ef.Key);
                var ordered = ef.Value.OrderByDescending(f => f.Length);
                foreach (var file in ordered)
                {
                    sb.AppendLine($"--{file.Name} - {(double)file.Length/1024}kb");
                }
            }
            return sb.ToString();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + reportFileName;
            File.WriteAllText(path, textContent);
        }
    }
}
