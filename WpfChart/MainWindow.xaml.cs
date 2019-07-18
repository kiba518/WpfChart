using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfChart
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            string con = btn.Content.ToString();
       
            Window win;
            switch (con)
            {
                case "雷达图原始":
                      win = new RandarOrignal(); 
                    break;
                case "雷达图修改":
                      win = new RandarModify();
                    win.Show();
                    break;
                case "域图":
                    win = new AreaSeriesChart();
                    win.Show();
                    break;
                case "横柱图":
                    win = new BarSeriesChart();
                    win.Show();
                    break;
                case "气泡图":
                    win = new BubbleChart();
                    win.Show();
                    break;
                case "柱形图":
                    win = new ColumnSeriesChart();
                    win.Show();
                    break;
                case "线形图":
                    win = new LineSeriesChart();
                    win.Show();
                    break;
                case "饼图":
                    win = new PieChart();
                    win.Show();
                    break;
                case "自定义饼图":
                    win = new PieChartCustom();
                    win.Show();
                    break;
                case "分散图":
                    win = new ScatterSeriesChart();
                    win.Show();
                    break;
              
                default:
                    win = new RandarOrignal();
                    break;
            }
            win.Show();
        }
    }
}
