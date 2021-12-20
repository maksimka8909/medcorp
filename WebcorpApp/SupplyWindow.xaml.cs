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

namespace WebcorpApp
{
    /// <summary>
    /// Логика взаимодействия для SupplyWindow.xaml
    /// </summary>
    public partial class SupplyWindow : Window
    {
        public SupplyWindow()
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

        private void dgEquipment_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmEquipmentDelete.IsEnabled = dgEquipment.SelectedItem != null;
        }

        private void cmEquipmentDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void dgDrugs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmDrugDelete.IsEnabled = dgDrugs.SelectedItem != null;
        }

        private void cmDrugDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void rbEquipment_Checked(object sender, RoutedEventArgs e)
        {
            if (cbEquipment == null) { return; }

            cbEquipment.Visibility = Visibility.Visible;
            cbDrug.Visibility = Visibility.Collapsed;
            dgEquipment.Visibility = Visibility.Visible;
            dgDrugs.Visibility = Visibility.Collapsed;
        }

        private void rbDrug_Checked(object sender, RoutedEventArgs e)
        {
            cbEquipment.Visibility = Visibility.Collapsed;
            cbDrug.Visibility = Visibility.Visible;
            dgEquipment.Visibility = Visibility.Collapsed;
            dgDrugs.Visibility = Visibility.Visible;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
