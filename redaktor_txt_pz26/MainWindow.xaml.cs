using System.Windows;
namespace redaktor_txt_pz26
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        string filename = string.Empty;

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
            if (BAN.FontWeight == FontWeights.Bold)
            {
                BAN.FontWeight = FontWeights.Normal;
            }
            else
            {
                BAN.FontWeight = FontWeights.Bold;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


        }

        private void newFileMenuItem_Click(object sender, RoutedEventArgs e)
        {
            CreateFileWindow createFileWindow = new CreateFileWindow();
            if (createFileWindow.ShowDialog() == true)
                filename = createFileWindow.FileName;
            
                
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void pressItalic_Click(object sender, RoutedEventArgs e)
        {
            BAN.FontStyle = FontStyles.Italic;
        }

        private void pressUndreLine_Click(object sender, RoutedEventArgs e)
        {
            BAN.TextDecorations = TextDecorations.Underline;
        }

        private void UpdateCursorPosition()
        {
            int row = BAN.GetLineIndexFromCharacterIndex(BAN.CaretIndex);
            int col = BAN.CaretIndex - BAN.GetLineIndexFromCharacterIndex(row);
            BAN.Text = $"строка: {row + 1} столбец: {col + 1}";
        }


    }
}
