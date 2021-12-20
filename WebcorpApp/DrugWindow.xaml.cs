using HospitalAPI.Classes;
using RestSharp;
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
using WebcorpApp.Classes;

namespace WebcorpApp
{
    /// <summary>
    /// Логика взаимодействия для DrugWindow.xaml
    /// </summary>
    public partial class DrugWindow : Window
    {
        //режим работы окна
        public bool isNew;

        private RestClient apiClient = ApiBuilder.GetInstance();
        public DrugWindow()
        {
            InitializeComponent();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            this.Owner.IsEnabled = true;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            if (tbDescription.Text.Trim().Length != 0 && tbManufacturer.Text.Trim().Length != 0 
                && tbName.Text.Trim().Length != 0)
            {
                PreparationView preparationView = new PreparationView()
                {
                    Name = tbName.Text,
                    Manufacturer = tbManufacturer.Text,
                    Description = tbDescription.Text,
                    IdProvider = 1
                };
                var ptResponse = apiClient.Post(new RestRequest("preparation/add")
                        .AddJsonBody(
                            preparationView
                        ));
                MessageBox.Show("Препарат успешно добавлен");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка. Не все поля заполнены");
            }
        }
    }
}
