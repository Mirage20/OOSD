using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SalesLeadsManagementSystem.Analysis
{

    public partial class frmGraph : Form
    {
        private List<float> data = null;
        private string series = null;
        private DateTime start;

        public string Series
        {
            get { return series; }
            set { series = value; }
        }

        public List<float> Data
        {
            get { return data; }
            set { data = value; }
        }

        public Chart Graph
        {
            get { return chartRevenue; }
            set { chartRevenue = value; }
        }

        public frmGraph(DateTime start)
        {
            InitializeComponent();
            this.start = start;
            foreach (var series in chartRevenue.Series)
            {
                series.Points.Clear();
            }
            
        }

        public void drawGraph(List<float> data, string series)
        {

            chartRevenue.Series.Add(series);
            DateTime temp = start;
            chartRevenue.Legends.Add(new Legend(series));
            chartRevenue.Series[series].Legend = series;
            chartRevenue.ChartAreas[0].AxisX.Interval = 1;
            chartRevenue.ChartAreas[0].AxisY.Interval = data.Max()/25;
            
            chartRevenue.Series[series].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            for (int i = 0; i < data.Count; i++)
            {
                DateTime month = Convert.ToDateTime(start.AddMonths(i));
                chartRevenue.Series[series].Points.AddXY(month.ToString("MMM"),data.ElementAt(i));
            }
        }
    }
}
