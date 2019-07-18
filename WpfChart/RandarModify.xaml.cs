using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.DataVisualization.Charting;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfChart
{

    public partial class RandarModify : Window
    {
        List<ArgumentModel> argumentsList = new List<ArgumentModel>();
        List<ChartItem> datas = new List<ChartItem>();
        public RandarModify()
        {
            List<RandarModel> list = new List<RandarModel>();
            RandarModel m1 = new RandarModel() { Title = "上", Value = 100 };
            RandarModel m2 = new RandarModel() { Title = "上", Value = 30 };
            RandarModel m3 = new RandarModel() { Title = "上", Value = 10 };
            RandarModel m4 = new RandarModel() { Title = "上", Value = 20 };
            RandarModel m5 = new RandarModel() { Title = "上", Value = 36 };
            list.Add(m1);
            list.Add(m2);
            list.Add(m3);
            list.Add(m4);
            list.Add(m5);

            List<ArgumentModel> argumentsList = new List<ArgumentModel>();
            List<ChartItem> datas = new List<ChartItem>();
            ChartItem ci = new ChartItem();
            ci.Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#f28d20"));
            datas.Add(ci);
            List<ChartData> dataList = new List<ChartData>();
            ci.DataList = dataList;

            foreach (var item in list)
            {
                ChartData chartData = new ChartData();
                chartData.Data = item.Value;
                dataList.Add(chartData);
                ArgumentModel argumentModel = new ArgumentModel();
                argumentModel.Name = item.Title;
                argumentsList.Add(argumentModel);
            }

            InitializeComponent();
            this.DataContext = this;
            radarChartControl.Arguments = argumentsList;
            radarChartControl.Datas = datas;
            radarChartControl.Inti();
           

        }
    }
    public class RandarModel
    {
        public string Title { get; set; }
        public int Value { get; set; } 
    }
}
