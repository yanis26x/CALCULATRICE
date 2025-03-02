using System.Data;
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

namespace Calculatrice_cool;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void btn1_Click(object sender, RoutedEventArgs e)
    {
        screen.Text = screen.Text + "1";
    }

    private void btn2_Click(object sender, RoutedEventArgs e)
    {
        screen.Text = screen.Text + "2";
    }

    private void btn3_Click(object sender, RoutedEventArgs e)
    {
        screen.Text = screen.Text + "3";
    }

    private void btn4_Click(object sender, RoutedEventArgs e)
    {
        screen.Text = screen.Text + "4";
    }

    private void btn5_Click(object sender, RoutedEventArgs e)
    {
        screen.Text = screen.Text + "5";
    }

    private void btn6_Click(object sender, RoutedEventArgs e)
    {
        screen.Text = screen.Text + "6";
    }

    private void btn7_Click(object sender, RoutedEventArgs e)
    {
        screen.Text = screen.Text + "7";
    }

    private void btn8_Click(object sender, RoutedEventArgs e)
    {
        screen.Text = screen.Text + "8";
    }

    private void btn9_Click(object sender, RoutedEventArgs e)
    {
        screen.Text = screen.Text + "9";
    }

    private void btn0_Click(object sender, RoutedEventArgs e)
    {
        screen.Text = screen.Text + "0";
    }

    private void btnClear_Click(object sender, RoutedEventArgs e)
    {
        screen.Text = "";
    }

    private void btnPlus_Click(object sender, RoutedEventArgs e)
    {
        screen.Text = screen.Text + "+";
    }

    private void btnMinus_Click(object sender, RoutedEventArgs e)
    {
        screen.Text = screen.Text + "-";
    }

    private void btnMulti_Click(object sender, RoutedEventArgs e)
    {
        screen.Text = screen.Text + "*";
    }

    private void btnDiv_Click(object sender, RoutedEventArgs e)
    {
        screen.Text = screen.Text + "/";
    }

    private void btnEgal_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            string expression = screen.Text;
            DataTable dt = new DataTable();
            var result = dt.Compute(expression, "");
            screen.Text = result.ToString();
        }
        catch (Exception ex)
        {
            screen.Text = "tes stupide ou quoi ?";
        }
    }
}