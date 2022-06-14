using System;
using System.Collections.Generic;
using MyWebApi.Models;

namespace MyWebApi.Services
{
  public interface IChartService
  {
       List<ChartValues> ValuesBarChart();
        List<ChartValues> ValuesLineChart();
        List<ChartValues> ValuesScattedChart();
    }
    public class ChartService : IChartService
    {
        public ChartService()
        {

        }

        public List<ChartValues> ValuesBarChart()
        {
            List<ChartValues> values = new List<ChartValues>();
            values.Add(new ChartValues("Jan", 13));
            values.Add(new ChartValues("Feb", 20));
            values.Add(new ChartValues("Mar", 30));
            values.Add(new ChartValues("Apr", 50));
            values.Add(new ChartValues("Aug", 70));
            values.Add(new ChartValues("Nov", 75));

            return values;
        }

        public List<ChartValues> ValuesLineChart()
        {
            List<ChartValues> values = new List<ChartValues>();
            values.Add(new ChartValues("Jan", 13));
            values.Add(new ChartValues("Feb", 15));
            values.Add(new ChartValues("Mar", 30));
            values.Add(new ChartValues("Apr", 50));
            values.Add(new ChartValues("Aug", 70));
            values.Add(new ChartValues("Nov", 75));

            return values;

        }

        public List<ChartValues> ValuesScattedChart()
        {
            List<ChartValues> values = new List<ChartValues>();
            values.Add(new ChartValues("Jan", 15));
            values.Add(new ChartValues("Feb", 25));
            values.Add(new ChartValues("Mar", 32));
            values.Add(new ChartValues("Apr", 55));
            values.Add(new ChartValues("Aug", 75));
            values.Add(new ChartValues("Nov", 80));

            return values;

        }
    }
}
