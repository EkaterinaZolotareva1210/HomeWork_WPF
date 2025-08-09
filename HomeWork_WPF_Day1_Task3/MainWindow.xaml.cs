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

namespace HomeWork_WPF_Day1_Task3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double _newPositionX;
        private double _newPositionY;
        private double _MainGridWidth;
        private double _MainGridHeight;
        private double _buttonHeight;
        private double _buttonWidth;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_MouseEnter(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            _MainGridWidth = MainGrid.ActualWidth;
            _MainGridHeight = MainGrid.ActualHeight;
            _buttonHeight = RunningButton.Height;
            _buttonWidth = RunningButton.Width;
            _newPositionX = rnd.Next(0, (Convert.ToInt32(_MainGridWidth - _buttonWidth)));
            _newPositionY = rnd.Next(0, (Convert.ToInt32(_MainGridHeight - _buttonHeight)));
            RunningButton.Margin = new Thickness(_newPositionX, _newPositionY, 0, 0);
        }
    }
}
