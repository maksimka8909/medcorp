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
    /// Логика взаимодействия для StorekeeperMain.xaml
    /// </summary>
    public partial class StorekeeperMain : Window
    {
        private RestClient apiClient = ApiBuilder.GetInstance();
        public StorekeeperMain()
        {
            InitializeComponent();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            this.Owner.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> contentType = new List<string>() { "Оборудование", "Препарат", "Поставки" };
            cbContentType.ItemsSource = contentType;
            cbContentType.SelectedIndex = 0;
            var wschResponse = apiClient.Get<List<EquipmentData>>(new RestRequest("equipment/show/"));
            dgEquipments.ItemsSource = wschResponse.Data;
            var wschRespons = apiClient.Get<List<PreparationData>>(new RestRequest("preparation/show/"));
            dgDrugs.ItemsSource = wschRespons.Data;
        }

        private void cbContentType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbContentType.SelectedItem == null)
            {
                return;
            }
            
            ContentClear();
            switch (cbContentType.SelectedIndex)
            {
                case 0:
                    contentInventory.Visibility = Visibility.Visible;
                    break;
                case 1:
                    contentDrug.Visibility = Visibility.Visible;
                    break;
                case 2:
                    contentSupply.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void ContentClear()
        {
            contentInventory.Visibility = Visibility.Collapsed;
            contentDrug.Visibility = Visibility.Collapsed;
            contentSupply.Visibility = Visibility.Collapsed;
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

        private void dgEquipments_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmEquipmentChange.IsEnabled = dgEquipments.SelectedItem != null;
            cmEquipmentDelete.IsEnabled = dgEquipments.SelectedItem != null;
        }

        private void cmEquipmentAdd_Click(object sender, RoutedEventArgs e)
        {
            this.IsEnabled = false;
            new EquipmentWindow() { Owner = this, isNew = true }.Show();
        }

        private void cmEquipmentChange_Click(object sender, RoutedEventArgs e)
        {
            this.IsEnabled = false;
            new EquipmentWindow() { Owner = this, isNew = false }.Show();
        }

        private void cmEquipmentDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void dgDrugs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmDrugChange.IsEnabled = dgDrugs.SelectedItem != null;
            cmDrugDelete.IsEnabled = dgDrugs.SelectedItem != null;
        }

        private void cmDrugAdd_Click(object sender, RoutedEventArgs e)
        {
            this.IsEnabled = false;
            new DrugWindow() { Owner = this, isNew = true }.Show();
        }

        private void cmDrugChange_Click(object sender, RoutedEventArgs e)
        {
            this.IsEnabled = false;
            new DrugWindow() { Owner = this, isNew = false }.Show();
        }

        private void cmDrugDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void dgSupply_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmSupplyDelete.IsEnabled = dgSupply.SelectedItem != null;
        }

        private void cmSupplyAdd_Click(object sender, RoutedEventArgs e)
        {
            this.IsEnabled = false;
            new SupplyWindow() { Owner = this }.Show();
        }

        private void cmSupplyDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cmSupplyExcel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cmRefresh_Click(object sender, RoutedEventArgs e)
        {
            var wschResponse = apiClient.Get<List<EquipmentData>>(new RestRequest("equipment/show/"));
            dgEquipments.ItemsSource = wschResponse.Data;
            var wschRespons = apiClient.Get<List<PreparationData>>(new RestRequest("preparation/show/"));
            dgDrugs.ItemsSource = wschRespons.Data;
        }
    }
}
