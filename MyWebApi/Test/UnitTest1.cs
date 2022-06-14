using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyWebApi.Models;
using MyWebApi.Services;
using System;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        public ChartService chartService = new ChartService();

        [TestMethod]
        public void TestValuesBarChart()
        {
            //Assert.AreEqual(7, 7);
            List<ChartValues> list = chartService.ValuesBarChart();
            Assert.AreEqual(list.Count, 6);
        }
        [TestMethod]
        public void TestValuesLineChart()
        {
            List<ChartValues> list = chartService.ValuesLineChart();
            ChartValues value = new ChartValues("Apr", 50);
            ReferenceEquals(list[4], value);
        }
        [TestMethod]
        public void TestValuesScattedChart()
        {
            List<ChartValues> list = chartService.ValuesScattedChart();
            ChartValues value = new ChartValues("Nov", 80);
            ReferenceEquals(list[5], value);
        }
    }
}
