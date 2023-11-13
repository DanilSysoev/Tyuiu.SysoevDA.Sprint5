using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.SysoevDA.Sprint5.Task0.V23.Lib;

namespace Tyuiu.SysoevDA.Sprint5.Task0.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\Admin\source\repos\C#\Tyuiu.SysoevDA.Sprint5\Tyuiu.SysoevDA.Sprint5.Task0.V23\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExist = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
