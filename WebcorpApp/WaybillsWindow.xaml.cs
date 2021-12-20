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
    /// Логика взаимодействия для WaybillsWindow.xaml
    /// </summary>
    public partial class WaybillsWindow : Window
    {
        private RestClient apiClient = ApiBuilder.GetInstance();
        public WaybillsWindow()
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
            if (tbAmount.Text.Trim().Length != 0)
            {
                WaybillView waybillView = new WaybillView()
                {
                    Amount = Convert.ToDecimal(tbAmount.Text),
                    DateOfEnrollment = DateTime.Now,
                    IdEmployee =1
                };
                var ptResponse = apiClient.Post(new RestRequest("waybill/add")
                        .AddJsonBody(
                            waybillView
                        ));
                MessageBox.Show("Накладная успешно проведена");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка. Не все поля заполнены");
            }
        }
    }
}
