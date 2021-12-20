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
    /// Логика взаимодействия для CheckRecordWindow.xaml
    /// </summary>
    public partial class CheckRecordWindow : Window
    {
        private RestClient apiClient = ApiBuilder.GetInstance();
        public int id { get; set; }
        public CheckRecordWindow()
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
            if (tbComplaint.Text.Trim().Length !=0 && tbConlusion.Text.Trim().Length != 0 && tbPrescription.Text.Trim().Length != 0 
                && tbResult.Text.Trim().Length != 0)
            {
                CheckupByRecordView checkupByRecordView = new CheckupByRecordView()
                {
                    PatientComplaints = tbComplaint.Text,
                    ResultOfPatientCheckup = tbResult.Text,
                    Prescription = tbPrescription.Text,
                    Conclusion = tbConlusion.Text,
                    IdRecord = id
                };
                var ptResponse = apiClient.Post(new RestRequest("checkupbyrecord/add")
                        .AddJsonBody(
                            checkupByRecordView
                        ));
                MessageBox.Show("Осмотр успешно проведен");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка. Не все поля заполнены");
            }
        }
    }
}
