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
    /// Логика взаимодействия для AddPost.xaml
    /// </summary>
    public partial class AddPost : Window
    {
        private RestClient apiClient = ApiBuilder.GetInstance();
        public string tableName { get; set; }
        public int id { get; set; }

        public string name { get; set; }
        public string secondParam { get; set; }
        public AddPost()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (tableName=="Должности")
            {
                tbText.Text = "Зарплата";
            }
            else
            {
                tbText.Text = "Тип графика";
               
            }
            if (name != null)
            {
                tbName.Text = name.ToString();
                tbSalary.Text = secondParam.ToString();
                tbAdd.Text = "Изменение";
                btnAccept.Content = "Изменить";
            }
            else
            {
                tbAdd.Text = "Добавление";
                btnAccept.Content = "Добавить";
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            AdminMain adminMain = new AdminMain();
            adminMain.Show();
            this.Hide();
        }

        private void btnAccept_Click(object sender, RoutedEventArgs e)
        {
            
            if (tbName.Text.Trim().Length != 0 && tbSalary.Text.Trim().Length != 0)
            {
                if(btnAccept.Content.ToString() == "Добавить")
                {
                    switch (tableName)
                    {
                        case "Должности":
                            PostView postView = new PostView()
                            {
                                Name = tbName.Text.ToString(),
                                Salary = Convert.ToDecimal(tbSalary.Text.ToString())

                            };
                            var eqResponse = apiClient.Post(new RestRequest("post/add")
                                .AddJsonBody(
                                    postView
                                ));
                            break;
                        case "Графики работы":
                            WorkScheduleView workScheduleView = new WorkScheduleView()
                            {
                                Name = tbName.Text.ToString(),
                                TypeOfWorkSchedule = tbSalary.Text.ToString()
                            };
                            var ptResponse = apiClient.Post(new RestRequest("workschedule/add")
                                .AddJsonBody(
                                    workScheduleView
                                ));
                            break;
                    }
                    MessageBox.Show("Новая запись успешно создана");
                    AdminMain adminMain = new AdminMain();
                    adminMain.Show();
                    this.Hide();
                }
                else
                {
                    switch (tableName)
                    {
                        case "Должности":
                            PostView postView = new PostView()
                            {
                                IdPost = id,
                                Name = tbName.Text.ToString(),
                                Salary = Convert.ToDecimal(tbSalary.Text.ToString())

                            };
                            var eqResponse = apiClient.Post(new RestRequest("post/update")
                                .AddJsonBody(
                                    postView
                                ));
                            break;
                        case "Графики работы":
                            WorkScheduleView workScheduleView = new WorkScheduleView()
                            {
                                IdWorkSchedule = id,
                                Name = tbName.Text.ToString(),
                                TypeOfWorkSchedule = tbSalary.Text.ToString()
                            };
                            var ptResponse = apiClient.Post(new RestRequest("workschedule/update")
                                .AddJsonBody(
                                    workScheduleView
                                ));
                            break;
                    }
                    MessageBox.Show("Запись успешно изменена");
                    AdminMain adminMain = new AdminMain();
                    adminMain.Show();
                    this.Hide();
                }
                
            }
            else
            {
                string messageBoxText = "Пожалуйста заполните все поля.";
                string caption = "Ошибка";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;
                MessageBoxResult result;

                result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.OK);
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            AdminMain adminMain = new AdminMain();
            adminMain.Show();
            this.Hide();
        }
    }
}
