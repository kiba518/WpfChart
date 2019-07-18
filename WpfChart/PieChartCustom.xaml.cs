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
    public partial class PieChartCustom : Window
    {
        public PieChartCustom()
        {
            InitializeComponent();

            PieSeries series = chartPieSeries; 
            series.ItemsSource = new List<PieSeriesModel> {
            new PieSeriesModel(){Title="男人2",Value=1,Background=new SolidColorBrush(Colors.Red)  },
            new PieSeriesModel(){Title="女人2",Value=2,Background=new SolidColorBrush(Colors.Orange)  },
            new PieSeriesModel(){Title="外星人2",Value=11,Background=new SolidColorBrush(Colors.White)  }
            }; 
        }
    }
    public class PieSeriesModel
    {
        public string Title { get; set; }
        public int Value { get; set; }
        public Brush Background { get; set; }
    }
}
