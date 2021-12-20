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
    /// Логика взаимодействия для DoctorMain.xaml
    /// </summary>
    public partial class DoctorMain : Window
    {
        private RestClient apiClient = ApiBuilder.GetInstance();
        public DoctorMain()
        {
            InitializeComponent();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            this.Owner.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> contentType = new List<string>() { "Записи", "Осмотры" };
            cbContentType.ItemsSource = contentType;
            cbContentType.SelectedIndex = 0;
            var wschResponse = apiClient.Get<List<RecordData>>(new RestRequest("recordforinspection/show/"));
            dgRecords.ItemsSource = wschResponse.Data;
            var wschResponse1 = apiClient.Get<List<CheckupData>>(new RestRequest("checkupbyrecord/show/"));
            dgCheckup.ItemsSource = wschResponse1.Data;
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void dgRecords_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmRecordsCheck.IsEnabled = dgRecords.SelectedItem != null;
        }

        private void cmRecordsCheck_Click(object sender, RoutedEventArgs e)
        {
            this.IsEnabled = false;

            new CheckRecordWindow() { Owner = this, id = (dgRecords.SelectedItem as RecordData).id }.Show();
        }

        private void cbContentType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (cbContentType.SelectedIndex)
            {
                case 0:
                    ContentClear();
                    contentRecords.Visibility = Visibility.Visible;
                    var wschResponse = apiClient.Get<List<RecordData>>(new RestRequest("recordforinspection/show/"));
                    dgRecords.ItemsSource = wschResponse.Data;
                    var wschResponse1 = apiClient.Get<List<CheckupData>>(new RestRequest("checkupbyrecord/show/"));
                    dgCheckup.ItemsSource = wschResponse1.Data;
                    break;
                
                case 1:
                    ContentClear();
                    contentCheckup.Visibility = Visibility.Visible;
                    var wschResponse2 = apiClient.Get<List<RecordData>>(new RestRequest("recordforinspection/show/"));
                    dgRecords.ItemsSource = wschResponse2.Data;
                    var wschResponse3 = apiClient.Get<List<CheckupData>>(new RestRequest("checkupbyrecord/show/"));
                    dgCheckup.ItemsSource = wschResponse3.Data;
                    break;
            }
        }

        private void ContentClear()
        {
            contentRecords.Visibility = Visibility.Collapsed;
            contentCheckup.Visibility = Visibility.Collapsed;
        }
    }
}
