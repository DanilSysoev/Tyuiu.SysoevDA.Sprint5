﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.SysoevDA.Sprint5.Task6.V3.Lib;


namespace Tyuiu.SysoevDA.Sprint5.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V3.txt";

            var res = ds.LoadFromDataFile(path);

            int wait = 21;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckedExistFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V3.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExist = fileinfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
