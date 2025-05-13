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

namespace MoneyConverterWPF
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

        private void ConvertBtn_Click(object sender, RoutedEventArgs e)
        {
            int USD = 90;
            int EUR = 97;
            int CNY = 12;
            string CmbItem = ValCmb.SelectedItem.ToString();


            int Rub = Convert.ToInt32(RubTb.Text.ToString());

            if (CmbItem.Contains("USD"))
            {
                int Res = Rub * USD;
                Result.Text = Res.ToString();
            }
            if (CmbItem.Contains("EUR"))
            {
                int Res = Rub * EUR;
                Result.Text = Res.ToString();
            }
            if (CmbItem.Contains("CNY"))
            {
                int Res = Rub * CNY;
                Result.Text = Res.ToString();
            }
        }

        private void ValCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int USD = 90;
            int EUR = 97;
            int CNY = 12;
            string CmbItem = ValCmb.SelectedItem.ToString();


            int Rub = Convert.ToInt32(RubTb.Text.ToString());

            if (CmbItem.Contains("USD"))
            {
                int Res = Rub * USD;
                Result.Text = Res.ToString();
            }
            if (CmbItem.Contains("EUR"))
            {
                int Res = Rub * EUR;
                Result.Text = Res.ToString();
            }
            if (CmbItem.Contains("CNY"))
            {
                int Res = Rub * CNY;
                Result.Text = Res.ToString();
            }
        }

        private void RubTb_TextChanged(object sender, TextChangedEventArgs e)
        {         
        }
    }
    
}
