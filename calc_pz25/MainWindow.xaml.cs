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
using System.Text.RegularExpressions;

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
        private void press1Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "1";
        }

        private void press2Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "2";
        }

        private void press3Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "3";
        }

        private void press4Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "4";
        }

        private void press5Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "5";
        }

        private void press6Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "6";
        }

        private void press7Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "7";
        }

        private void press8Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "8";
        }

        private void press9Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "9";
        }

        private void pressEquallyButton_Click(object sender, RoutedEventArgs e)
        {
            string expression = inputTextBlock.Text;
            double result = Calculation(expression);
            inputTextBlock.Text = result.ToString();
        }

        private double Calculation(string expression)
        {            
            {
                // Создаем регулярное выражение
                Regex regex = new Regex(@"(\d+(\.\d+)?)\s*([-+*/])\s*(\d+(\.\d+)?)");

                // Ищем совпадения
                Match match = regex.Match(expression);

                if (match.Success)
                {
                    // Извлекаем операнды и оператор из найденного совпадения
                    double operand1 = double.Parse(match.Groups[1].Value);
                    double operand2 = double.Parse(match.Groups[4].Value);
                    char op = match.Groups[3].Value[0];

                    // Вычисляем результат в зависимости от оператора
                    switch (op)
                    {
                        case '+':
                            return operand1 + operand2;
                        case '-':
                            return operand1 - operand2;
                        case '*':
                            return operand1 * operand2;
                        case '/':
                            if (operand2 != 0)
                            {
                                return operand1 / operand2;
                            }
                            else
                            {
                                throw new DivideByZeroException("Деление на ноль!");
                            }
                        default:
                            throw new ArgumentException("Неверный оператор: " + op);
                    }
                }
                else
                {
                    throw new ArgumentException("Неверный формат выражения: " + expression);
                }
            }




        }

        private void pressslashButton_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "/";
        }

        private void pressMultiplyButton_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "*";
        }

        private void pressMinusButton_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "-";
        }

        private void pressPlusButton_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "+";
        }

    }
}
