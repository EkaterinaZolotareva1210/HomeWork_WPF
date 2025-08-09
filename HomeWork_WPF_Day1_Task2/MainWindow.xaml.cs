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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HomeWork_WPF_Day1_Task2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private static int count = 0; /*счетчик кликов*/
        private static int cycle = 0; /*счетчик циклов*/
        private void Button_NextColour(object sender, RoutedEventArgs e)
        {
            count++;
            Button button = (Button)sender;
            if (count == (1 + 3 * cycle))
            {
                Color color = Color.FromRgb(255, 0, 0);
                Red.Fill = new SolidColorBrush(color);
            }
            else
            {
                Color color = Color.FromRgb(128, 128, 128);
                Red.Fill = new SolidColorBrush(color);
            }
            if (count == (2 + 3 * cycle))
            {
                Color color = Color.FromRgb(255, 245, 0);
                Yellow.Fill = new SolidColorBrush(color);
            }
            else
            {
                Color color = Color.FromRgb(128, 128, 128);
                Yellow.Fill = new SolidColorBrush(color);
            }
            if (count == (3 + 3 * cycle))
            {
                Color color = Color.FromRgb(20, 115, 0);
                Green.Fill = new SolidColorBrush(color);
            }
            else
            {
                Color color = Color.FromRgb(128, 128, 128);
                Green.Fill = new SolidColorBrush(color);
            }
            if (count % 3 == 0) //счетчик циклов светофора
                cycle++;
        }
    }
}
