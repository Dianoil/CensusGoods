﻿using System;
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
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        //private void tehsupport_Click(object sender, RoutedEventArgs e)
        //{

        //}

        //private void product_Click(object sender, RoutedEventArgs e)
        //{

        //}

        //private void supply_Click(object sender, RoutedEventArgs e)
        //{

        //}

        //private void order_Click(object sender, RoutedEventArgs e)
        //{

        //}

        //private void debtnotebook_Click(object sender, RoutedEventArgs e)
        //{

        //}

        //private void expencenotebook_Click(object sender, RoutedEventArgs e)
        //{

        //}

        //private void reports_Click(object sender, RoutedEventArgs e)
        //{
        //    Reports reports = new Reports();
        //    this.Hide();
        //    reports.ShowDialog();
        //}

        //private void titlecomp_Click(object sender, RoutedEventArgs e)
        //{
        //    //информация о акке
        //}

        //private void OtchetBut_Click(object sender, RoutedEventArgs e)
        //{

        //}

        private void tariff_Click(object sender, RoutedEventArgs e)
        {

        }

        private void client_Click(object sender, RoutedEventArgs e)
        {

        }

        private void useracc_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OtchetBut_Click(object sender, RoutedEventArgs e)
        {

        }

        private void undo_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти из приложения?", "Выход", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }
    }
}
