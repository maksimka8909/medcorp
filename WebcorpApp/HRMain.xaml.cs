using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
using Excel = Microsoft.Office.Interop.Excel;

namespace WebcorpApp
{
    /// <summary>
    /// Логика взаимодействия для HRMain.xaml
    /// </summary>
    public partial class HRMain : Window
    {
        private RestClient apiClient = ApiBuilder.GetInstance();
        public HRMain()
        {
            InitializeComponent();
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

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            if(tbSearch.Text.Trim().Length == 0)
            {
                var wschResponse = apiClient.Get<List<PersonalFileData>>(new RestRequest("personalfile/show"));
                dgTableInfo.ItemsSource = wschResponse.Data;
            }
            else
            {
                var wschResponse = apiClient.Get<List<PersonalFileData>>(new RestRequest("personalfile/search/"+tbSearch.Text));
                dgTableInfo.ItemsSource = wschResponse.Data;
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddPersonalFile addPersonalFile = new AddPersonalFile();
            addPersonalFile.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (dgTableInfo.SelectedCells.Count == 0)
            {
                string messageBoxText = "Запись не выбрана";
                string caption = "Ошибка";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;
                MessageBoxResult result;

                result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.OK);
            }
            else
            {
                AddPersonalFile addPersonalFile = new AddPersonalFile();
                addPersonalFile.id = (dgTableInfo.SelectedItem as PersonalFileData).id;
                addPersonalFile.Show();
                this.Hide();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            var wschResponse = apiClient.Get<List<PersonalFileData>>(new RestRequest("personalfile/show"));
            dgTableInfo.ItemsSource = wschResponse.Data;
        }

        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
            if (dgTableInfo.SelectedCells.Count == 0)
            {
                string messageBoxText = "Запись не выбрана";
                string caption = "Ошибка";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;
                MessageBoxResult result;

                result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.OK);
            }
            else
            {
                Excel.Application ex = new Microsoft.Office.Interop.Excel.Application();
                ex.Visible = true;
                ex.SheetsInNewWorkbook = 1;
                Excel.Workbook workBook = ex.Workbooks.Add(Type.Missing);
                ex.DisplayAlerts = false;
                Excel.Worksheet sheet = (Excel.Worksheet)ex.Worksheets.get_Item(1);
                sheet.Name = $"ЛД {(dgTableInfo.SelectedItem as PersonalFileData).surname} {(dgTableInfo.SelectedItem as PersonalFileData).name.Substring(0,1)}.";

                sheet.Cells[1, 1] = "Фамилия";
                sheet.Cells[2, 1] = "Имя";
                sheet.Cells[3, 1] = "Отчество";
                sheet.Cells[4, 1] = "День рождения";
                sheet.Cells[5, 1] = "Образование";
                sheet.Cells[6, 1] = "Пол";
                sheet.Cells[7, 1] = "СНИЛС";
                sheet.Cells[8, 1] = "ИНН";
                sheet.Cells[9, 1] = "Серия паспорта";
                sheet.Cells[10, 1] = "Номер паспорта";
                sheet.Cells[11, 1] = "Трудовая книжка";
                sheet.Cells[12, 1] = "Номер телефона";
                sheet.Cells[13, 1] = "Номер карты";
                sheet.Cells[14, 1] = "Военный билет";


                sheet.Cells[1, 2] = (dgTableInfo.SelectedItem as PersonalFileData).surname;
                    sheet.Cells[2, 2] = (dgTableInfo.SelectedItem as PersonalFileData).name;
                    sheet.Cells[3, 2] = (dgTableInfo.SelectedItem as PersonalFileData).middleName;
                    sheet.Cells[4, 2] = (dgTableInfo.SelectedItem as PersonalFileData).birthday;
                    sheet.Cells[5, 2] = (dgTableInfo.SelectedItem as PersonalFileData).education;
                sheet.Cells[6, 2] = (dgTableInfo.SelectedItem as PersonalFileData).gender;
                sheet.Cells[7, 2] = (dgTableInfo.SelectedItem as PersonalFileData).snils;
                sheet.Cells[8, 2] = (dgTableInfo.SelectedItem as PersonalFileData).inn;
                sheet.Cells[9, 2] = (dgTableInfo.SelectedItem as PersonalFileData).passportSeries;
                sheet.Cells[10, 2] = (dgTableInfo.SelectedItem as PersonalFileData).passportNumber;
                sheet.Cells[11, 2] = (dgTableInfo.SelectedItem as PersonalFileData).employmentHistory;
                sheet.Cells[12, 2] = (dgTableInfo.SelectedItem as PersonalFileData).phonenumber;
                sheet.Cells[13, 2] = (dgTableInfo.SelectedItem as PersonalFileData).requisites;
                sheet.Cells[14, 2] = (dgTableInfo.SelectedItem as PersonalFileData).militaryId;


                var headers = sheet.get_Range("A1", "E100");
                headers.Cells.Font.Size = 14;
                var aRange = sheet.get_Range("A1", "E100");
                aRange.Columns.AutoFit();
            }
        }
    }
}
