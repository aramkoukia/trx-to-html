using System;
using System.IO;
using System.Net.Mime;
using System.Xml.Serialization;
using RazorEngine.Templating;

namespace TrxToHtml
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var trxFilePath = "";
            if (args.Length == 0)
            {
                //trxFilePath = @"C:\UMTest\Results\PerfResults 2016-06-07_10-36-53.trx";
                return;
            }

            trxFilePath = args[0];
            var testRun = GetTestRunInfo(trxFilePath);
            var html = GenerateHtml(testRun);

            File.WriteAllText(trxFilePath + ".html", html);
        }

        private static TestRun GetTestRunInfo(string trxFilePath)
        {
            var mySerializer = new XmlSerializer(typeof (TestRun));
            var myFileStream = new FileStream(trxFilePath, FileMode.Open);
            return (TestRun) mySerializer.Deserialize(myFileStream);
        }

        private static string GenerateHtml(TestRun testRun)
        {
            var templateService = new TemplateService();
            var Path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            var emailHtmlBody = templateService.Parse(File.ReadAllText( Path + @"\TrxTemplate.cshtml"), testRun, null, null);
            return emailHtmlBody;
        }
    }
}