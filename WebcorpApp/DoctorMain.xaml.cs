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
    /// Логика взаимодействия для DoctorMain.xaml
    /// </summary>
    public partial class DoctorMain : Window
    {
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
            new CheckRecordWindow() { Owner = this }.Show();
        }

        private void cbContentType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (cbContentType.SelectedIndex)
            {
                case 0:
                    ContentClear();
                    contentRecords.Visibility = Visibility.Visible;
                    break;
                
                case 1:
                    ContentClear();
                    contentCheckup.Visibility = Visibility.Visible;
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
