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
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ScatterSeriesChart : Window
    {
        public ScatterSeriesChart()
        {
            InitializeComponent();
            ScatterSeries series = (ScatterSeries)chart.Series[0];

            series.ItemsSource =
          new KeyValuePair<string, int>[] {
          new KeyValuePair<string,int>("男人",1),
          new KeyValuePair<string,int>("女人",2),
          new KeyValuePair<string,int>("外星人",10),
        };
            ScatterSeries series2 = chartColumnSeries2;
            series2.ItemsSource =
        new KeyValuePair<string, int>[] {
          new KeyValuePair<string,int>("男人2",1),
          new KeyValuePair<string,int>("女人2",2),
          new KeyValuePair<string,int>("外星人2",10),
      };
        }
    }
}
