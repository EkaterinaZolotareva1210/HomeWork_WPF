using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HomeWork_WPF;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private static int count; //инициализация счетчика кликов как поля класса MainWindow
    protected void Button_Click(object sender, RoutedEventArgs e)
    {
        count++; 
        Button button = (Button)sender;
        ResultText.Text = $"{count}";
    }
}