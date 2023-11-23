using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.SysoevDA.Sprint5.Task7.V18.Lib; 


namespace Tyuiu.SysoevDA.Sprint5.Task7.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistFile()
        {
            string path = @"C:\Users\Admin\source\repos\C#\Tyuiu.SysoevDA.Sprint5\Tyuiu.SysoevDA.Sprint5.Task7.V18\bin\DebugOutPutDataFileTask7V18.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExist = fileinfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
