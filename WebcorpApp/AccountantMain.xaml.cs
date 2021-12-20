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

namespace WebcorpApp
{
    /// <summary>
    /// Логика взаимодействия для AccountantMain.xaml
    /// </summary>
    public partial class AccountantMain : Window
    {
        public AccountantMain()
        {
            InitializeComponent();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            this.Owner.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            //Application.Current.Shutdown();
            this.Close();
        }

        private void cmWaybillsAdd_Click(object sender, RoutedEventArgs e)
        {
            this.IsEnabled = false;
            new WaybillsWindow() { Owner = this }.Show();
        }
    }
}
