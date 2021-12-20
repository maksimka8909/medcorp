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
        public int id { get; set; }

        public string name { get; set; }
        public AddOneFieldRecordMain()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (name != null)
            {
                tbName.Text = name.ToString();
                tbAdd.Text = "Изменение";
                btnAccept.Content = "Изменить";
            }
            else
            {
                tbAdd.Text = "Добавление";
                btnAccept.Content = "Добавить";
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            AdminMain adminMain = new AdminMain();
            adminMain.Show();
            this.Hide();
        }

        private void btnAccept_Click(object sender, RoutedEventArgs e)
        {
            if (tbName.Text.Trim().Length != 0)
            {
                if (btnAccept.Content.ToString() == "Добавить")
                {
                    switch (tableName)
                    {
                        case "Типы оборудования":
                            TypeOfEquipmentView toev = new TypeOfEquipmentView()
                            {
                                Name = tbName.Text.ToString()
                            };
                            var eqResponse = apiClient.Post(new RestRequest("typeofequipment/add")
                                .AddJsonBody(
                                    toev
                                ));
                            break;
                        case "Типы выплат":
                            PayTypeView payTypeView = new PayTypeView()
                            {
                                Name = tbName.Text.ToString()
                            };
                            var ptResponse = apiClient.Post(new RestRequest("paytype/add")
                                .AddJsonBody(
                                    payTypeView
                                ));
                            break;

                        case "Графики работы":
                            WorkScheduleView workScheduleView = new WorkScheduleView()
                            {
                                Name = tbName.Text.ToString()
                            };
                            var wschResponse = apiClient.Post(new RestRequest("workschedule/add")
                                .AddJsonBody(workScheduleView));
                            break;
                        case "Причины увольнения":
                            ReasonOfDismissalData reasonOfDismissalData = new ReasonOfDismissalData()
                            {
                                name = tbName.Text.ToString()
                            };
                            var rodResponse = apiClient.Post(new RestRequest("reasonofdismissal/add")
                                .AddJsonBody(reasonOfDismissalData));
                            break;

                        case "Типы исследования":
                            TypeOfResearchView typeOfResearchView = new TypeOfResearchView()
                            {
                                Name = tbName.Text.ToString()
                            };
                            var torResponse = apiClient.Post(new RestRequest("typeofresearch/add")
                                .AddJsonBody(typeOfResearchView));
                            break;

                        case "Типы отпуска":
                            TypeOfVacationView typeOfVacationView = new TypeOfVacationView()
                            {
                                Name = tbName.Text.ToString()
                            };
                            var tovResponse = apiClient.Post(new RestRequest("typeofvacation/add")
                                .AddJsonBody(typeOfVacationView));
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
                        case "Типы оборудования":
                            TypeOfEquipmentView toev = new TypeOfEquipmentView()
                            {
                                IdTypeOfEquipment = id,
                                Name = tbName.Text.ToString()
                            };
                            var eqResponse = apiClient.Post(new RestRequest("typeofequipment/update")
                                .AddJsonBody(
                                    toev
                                ));
                            break;
                        case "Типы выплат":
                            PayTypeView payTypeView = new PayTypeView()
                            {
                                IdPayType = id,
                                Name = tbName.Text.ToString()
                            };
                            var ptResponse = apiClient.Post(new RestRequest("paytype/update")
                                .AddJsonBody(
                                    payTypeView
                                ));
                            break;

                        case "Графики работы":
                            WorkScheduleView workScheduleView = new WorkScheduleView()
                            {
                                IdWorkSchedule = id,
                                Name = tbName.Text.ToString()
                            };
                            var wschResponse = apiClient.Post(new RestRequest("workschedule/update")
                                .AddJsonBody(workScheduleView));
                            break;
                        case "Причины увольнения":
                            ReasonOfDismissalData reasonOfDismissalData = new ReasonOfDismissalData()
                            {
                                id = id,
                                name = tbName.Text.ToString()
                            };
                            var rodResponse = apiClient.Post(new RestRequest("reasonofdismissal/update")
                                .AddJsonBody(reasonOfDismissalData));
                            break;

                        case "Типы исследования":
                            TypeOfResearchView typeOfResearchView = new TypeOfResearchView()
                            {
                                IdTypeOfResearch = id,
                                Name = tbName.Text.ToString()
                            };
                            var torResponse = apiClient.Post(new RestRequest("typeofresearch/update")
                                .AddJsonBody(typeOfResearchView));
                            break;

                        case "Типы отпуска":
                            TypeOfVacationView typeOfVacationView = new TypeOfVacationView()
                            {
                                IdTypeOfVacation = id,
                                Name = tbName.Text.ToString()
                            };
                            var tovResponse = apiClient.Post(new RestRequest("typeofvacation/update")
                                .AddJsonBody(typeOfVacationView));
                            break;
                    }
                    MessageBox.Show("Новая запись успешно изменена");
                    AdminMain adminMain = new AdminMain();
                    adminMain.Show();
                    this.Hide();
                }
            }
            else
            {
                string messageBoxText = "Пожалуйста заполните поле.";
                string caption = "Ошибка";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;
                MessageBoxResult result;

                result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.OK);
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            AdminMain adminMain = new AdminMain();
            adminMain.Show();
            this.Hide();

        }
    }
}
