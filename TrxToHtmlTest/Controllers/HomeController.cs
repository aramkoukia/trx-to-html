using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Serialization;
using TrxToHtml;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var trxFilePath = @"C:\UMTest\Results\TestResults 2016-06-07_13-06-10.trx";

            var testRun = GetTestRunInfo(trxFilePath);
            ViewData.Model = testRun;
            //var html = GenerateHtml(testRun);
            return View();
        }

        private static TestRun GetTestRunInfo(string trxFilePath)
        {
            var mySerializer = new XmlSerializer(typeof(TestRun));
            var myFileStream = new FileStream(trxFilePath, FileMode.Open);
            var result = (TestRun)mySerializer.Deserialize(myFileStream);
            myFileStream.Close();
            return result;
        }
    }
}