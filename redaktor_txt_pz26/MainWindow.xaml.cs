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

namespace redaktor_txt_pz26
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

        private void escButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void acceptButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Действие выполнено");
        }

        private void pressBold_Click(object sender, RoutedEventArgs e)
        {
            if (BAN.Selection.Text.Length > 0)
            {
                if (BAN.Selection.GetPropertyValue(TextElement.FontWeightProperty).Equals(FontWeights.Bold))
                {
                    BAN.Selection.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Normal);
                }
                else
                {
                    BAN.Selection.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Bold);
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


        }
    }
}
