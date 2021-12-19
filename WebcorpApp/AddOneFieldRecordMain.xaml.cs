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
using WebcorpApp.Models;

namespace WebcorpApp
{
    /// <summary>
    /// Логика взаимодействия для AddOneFieldRecordMain.xaml
    /// </summary>
    public partial class AddOneFieldRecordMain : Window
    {
        private RestClient apiClient = ApiBuilder.GetInstance();
        public string tableName { get; set; }
        public AddOneFieldRecordMain()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
               
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Hide();
        }

        private void btnAccept_Click(object sender, RoutedEventArgs e)
        {
            if (tbName.Text.Trim().Length != 0)
            {
                switch (tableName)
                {
                    case "Типы оборудования":
                        var eqResponse = apiClient.Post(new RestRequest("typeofequipment/add")
                            .AddJsonBody(new
                            {
                                Name = tbName.Text.ToString()
                            }));
                        break;

                    case "Графики работы":
                        var wschResponse = apiClient.Post(new RestRequest("workschedule/add")
                            .AddJsonBody(new
                            {
                                Name = tbName.Text.ToString()
                            }));
                        break;
                    case "Причины увольнения":
                        var rodResponse = apiClient.Post(new RestRequest("reasonofdismissal/add")
                            .AddJsonBody(new
                            {
                                Name = tbName.Text.ToString()
                            }));
                        break;

                    case "Типы исследования":
                        var torResponse = apiClient.Post(new RestRequest("typeofresearch/add")
                            .AddJsonBody(new
                            {
                                Name = tbName.Text.ToString()
                            }));
                        break;

                    case "Типы отпуска":
                        var tovResponse = apiClient.Post(new RestRequest("typeofvacation/add")
                            .AddJsonBody(new
                            {
                                Name = tbName.Text.ToString()
                            }));
                        break;
                }
                MessageBox.Show("Новая запись успешно создана");

            }
            else
            {
                string messageBoxText = "Добавление не удалось. Пожалуйста заполните поле.";
                string caption = "Ошибка";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;
                MessageBoxResult result;

                result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.OK);
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();

        }
    }
}
