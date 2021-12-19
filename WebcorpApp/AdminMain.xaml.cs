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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WebcorpApp.Classes;
using WebcorpApp.Models;

namespace WebcorpApp
{
    /// <summary>
    /// Логика взаимодействия для AdminMain.xaml
    /// </summary>
    public partial class AdminMain : Window
    {
        private RestClient apiClient = ApiBuilder.GetInstance();

        
        public AdminMain()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Hide();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            switch (cbTables.SelectionBoxItem.ToString())
            {
                case "Типы оборудования":
                    var eqResponse = apiClient.Get<List<TypeOfEquipmentData>>(new RestRequest("typeofequipment/show"));
                    dgTableInfo.ItemsSource = eqResponse.Data;
                    break;

                case "Графики работы":
                    var wschResponse = apiClient.Get<List<WorkScheduleData>>(new RestRequest("workschedule/show"));
                    dgTableInfo.ItemsSource = wschResponse.Data;
                    break;

                case "Должности":
                    var postResponse = apiClient.Get<List<PostData>>(new RestRequest("post/show"));
                    dgTableInfo.ItemsSource = postResponse.Data;
                    break;

                case "Причины увольнения":
                    var rodResponse = apiClient.Get<List<ReasonOfDismissalData>>(new RestRequest("reasonofdismissal/show"));
                    dgTableInfo.ItemsSource = rodResponse.Data;
                    break;

                case "Типы исследования":
                    var torResponse = apiClient.Get<List<ReasonOfDismissalData>>(new RestRequest("typeofresearch/show"));
                    dgTableInfo.ItemsSource = torResponse.Data;
                    break;

                case "Типы отпуска":
                    var tovResponse = apiClient.Get<List<TypeOfVacationData>>(new RestRequest("typeofvacation/show"));
                    dgTableInfo.ItemsSource = tovResponse.Data;
                    break;

                case "Типы выплат":
                    var ptResponse = apiClient.Get<List<PayTypeData>>(new RestRequest("paytype/show"));
                    dgTableInfo.ItemsSource = ptResponse.Data;
                    break;

                case "Пользователи":
                    var uResponse = apiClient.Get<List<UserData>>(new RestRequest("user/show"));
                    dgTableInfo.ItemsSource = uResponse.Data;

                    break;
            }
        }


        private void cbTables_DropDownClosed(object sender, EventArgs e)
        {
            switch (cbTables.SelectionBoxItem.ToString())
            {
                case "Типы оборудования":
                    var eqResponse = apiClient.Get<List<TypeOfEquipmentData>>(new RestRequest("typeofequipment/show"));
                    dgTableInfo.ItemsSource = eqResponse.Data;
                    break;

                case "Графики работы":
                    var wschResponse = apiClient.Get<List<WorkScheduleData>>(new RestRequest("workschedule/show"));
                    dgTableInfo.ItemsSource = wschResponse.Data;
                    break;

                case "Должности":
                    var postResponse = apiClient.Get<List<PostData>>(new RestRequest("post/show"));
                    dgTableInfo.ItemsSource = postResponse.Data;
                    break;

                case "Причины увольнения":
                    var rodResponse = apiClient.Get<List<ReasonOfDismissalData>>(new RestRequest("reasonofdismissal/show"));
                    dgTableInfo.ItemsSource = rodResponse.Data;
                    break;

                case "Типы исследования":
                    var torResponse = apiClient.Get<List<ReasonOfDismissalData>>(new RestRequest("typeofresearch/show"));
                    dgTableInfo.ItemsSource = torResponse.Data;
                    break;

                case "Типы отпуска":
                    var tovResponse = apiClient.Get<List<TypeOfVacationData>>(new RestRequest("typeofvacation/show"));
                    dgTableInfo.ItemsSource = tovResponse.Data;
                    break;

                case "Типы выплат":
                    var ptResponse = apiClient.Get<List<PayTypeData>>(new RestRequest("paytype/show"));
                    dgTableInfo.ItemsSource = ptResponse.Data;
                    break;

                case "Пользователи":
                    var uResponse = apiClient.Get<List<UserData>>(new RestRequest("user/show"));
                    dgTableInfo.ItemsSource = uResponse.Data;

                    break;
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Owner.Show();
            this.Hide();
            
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Owner.Close();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddOneFieldRecordMain addOneFieldRecordMain = new AddOneFieldRecordMain();
            addOneFieldRecordMain.Owner = this;
            addOneFieldRecordMain.tableName = cbTables.SelectionBoxItem.ToString();
            addOneFieldRecordMain.Show();
        }
    }
}
