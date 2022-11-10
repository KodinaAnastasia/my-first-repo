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

namespace KodinaGit
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
        public int number = 0;
        //+
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            number += 1;
            label1.Content = $"Число: {number}";
        }
        //-
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            number -= 1;
            label1.Content = $"Число: {number}";
        }
    }
}
