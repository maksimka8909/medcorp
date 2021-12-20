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
    /// Логика взаимодействия для PatientMain.xaml
    /// </summary>
    public partial class PatientMain : Window
    {
        private RestClient apiClient = ApiBuilder.GetInstance();
        public PatientMain()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (dpDateOfCheckup.SelectedDate != null)
            {
                if (dpDateOfCheckup.SelectedDate.Value <= DateTime.Now)
                {
                    MessageBox.Show("Нельзя поставить дату записи меньше текущей");
                }
                else
                {
                    RecordForInspectionView recordForInspectionView = new RecordForInspectionView()
                    {
                        Date = dpDateOfCheckup.SelectedDate.Value,
                        Address = "Улица Иванова, дом 6 корп 1",
                        Status = true, 
                        IdPatient = 1,
                        IdEmployee = 3

                    };
                    var ptResponse = apiClient.Post(new RestRequest("recordforinspection/add")
                        .AddJsonBody(
                            recordForInspectionView
                        ));
                    MessageBox.Show("Новая запись успешно создана");
                    var wschResponse = apiClient.Get<List<RecordData>>(new RestRequest("recordforinspection/show/"));
                    dgTableInfo.ItemsSource = wschResponse.Data;
                }
                
            }
            else
            {
                MessageBox.Show("Дата не выбрана");
            }

        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                Owner.Show();
                this.Hide();
            }
            catch
            {
                Application.Current.Shutdown();
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var wschResponse = apiClient.Get<List<RecordData>>(new RestRequest("recordforinspection/show/"));
            dgTableInfo.ItemsSource = wschResponse.Data;
        }
    }
}
