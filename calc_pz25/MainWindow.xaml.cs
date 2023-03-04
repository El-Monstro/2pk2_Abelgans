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

namespace calc_pz25
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void press0Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "0";
        }
        private void resultButtmon_Click(object sender, RoutedEventArgs e)
        {
            string expression = inputTextBlock.Text;
            inputTextBlock.Text = Calculation(expression).ToString();
        }
        private double Calculation(string expression)
        {
            string pattern = @"(\d+)(\D)(\d+)"
        }
    }
}
