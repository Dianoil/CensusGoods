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
using System.Windows.Shapes;

namespace CensusGoods.Wind
{
    /// <summary>
    /// Логика взаимодействия для Autorization.xaml
    /// </summary>
    public partial class Autorization : Window
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void entry_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.ShowDialog();
            this.Hide();
        }

        private void undo_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void registr_Click(object sender, RoutedEventArgs e)
        {
            Registrat registrat = new Registrat();
            registrat.ShowDialog();
            this.Hide();
        }

        private void help_Click(object sender, RoutedEventArgs e)
        {
            Help help = new Help();
            help.ShowDialog();
            this.Hide();
        }

        private void tehsupport_Click(object sender, RoutedEventArgs e)
        {
            Support support = new Support();
            support.ShowDialog();
            this.Hide();
        }
    }
}
