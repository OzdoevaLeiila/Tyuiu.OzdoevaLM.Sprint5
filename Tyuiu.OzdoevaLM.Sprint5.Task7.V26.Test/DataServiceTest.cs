using System.IO;
using Tyuiu.OzdoevaLM.Sprint5.Task7.V26.Lib;

namespace Tyuiu.OzdoevaLM.Sprint5.Task7.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V26.txt";

            FileInfo file = new FileInfo(path);
            bool fileExists = file.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
