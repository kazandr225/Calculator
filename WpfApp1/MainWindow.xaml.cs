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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Model.tbSymb = tbSymb; //символ

            Model.first = tbFirstNum; //первое
            Model.second = tbSecondNum; //второе
            Model.result = tbResult; //результат

            cbOperations.ItemsSource = Model.datalist;
        }

        private void btnResult_Click(object sender, RoutedEventArgs e)
        {
            Model.calculations(cbOperations.SelectedIndex); //вычисление, передаем номер операции
        }

        private void cbOperations_SelectionChanged(object sender, SelectionChangedEventArgs e) //меняем знак при выборе
        {
            Model.Combx = cbOperations.SelectedIndex;
        }

        private void OnPreviewTextInput(object sender, TextCompositionEventArgs e) //ограничиваем допустимые значения цифрами и запятой
        {
            e.Handled = "0123456789,".IndexOf(e.Text) < 0;
        }
    }
}
