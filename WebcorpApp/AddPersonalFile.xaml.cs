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
    /// Логика взаимодействия для AddPersonalFile.xaml
    /// </summary>
    public partial class AddPersonalFile : Window
    {
        private RestClient apiClient = ApiBuilder.GetInstance();
        public int id { get; set; }
        public AddPersonalFile()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, RoutedEventArgs e)
        {
            if (tbEducation.Text.Trim().Length != 0 && tbGender.Text.Trim().Length != 0
                && tbInn.Text.Trim().Length != 0 && tbName.Text.Trim().Length != 0
                && tbNumber.Text.Trim().Length != 0 && tbPSeria.Text.Trim().Length != 0
                && tbRequisites.Text.Trim().Length != 0 && tbSnils.Text.Trim().Length != 0
                && tbSurname.Text.Trim().Length != 0 && tbWorkBook.Text.Trim().Length != 0
                && tbPNumber.Text.Trim().Length != 0 && dpBirthday.SelectedDate != null)
            {
                PersonalFileView personalFileView = new PersonalFileView()
                {
                    Surname = tbSurname.Text.ToString(),
                    Name = tbName.Text.ToString(),
                    MiddleName = tbMiddleName.Text.Trim(),
                    Gender = tbGender.Text.ToString(),
                    Education = tbEducation.Text.ToString(),
                    Email = tbEmail.Text.Trim(),
                    Inn = tbInn.Text.ToString(),
                    Requisites = tbRequisites.Text.ToString(),
                    Phonenumber = tbNumber.Text.ToString(),
                    PassportSeries = tbPSeria.Text.ToString(),
                    PassportNumber = tbPNumber.Text.ToString(),
                    Snils = tbSnils.Text.ToString(),
                    EmploymentHistory = tbWorkBook.Text.ToString(),
                    Birthday = dpBirthday.SelectedDate.Value
                };
                var eqResponse = apiClient.Post(new RestRequest("personalfile/add")
                               .AddJsonBody(
                                   personalFileView
                               ));
                MessageBox.Show("Новая дело успешно создано");
                HRMain hRMain = new HRMain();
                hRMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Отмена операции, не все поля заполнены");
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            HRMain hRMain = new HRMain();
            hRMain.Show();
            this.Hide();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (id != 0)
            {
                var eqResponse = apiClient.Get<List<PersonalFileData>>(new RestRequest("personalfile/show/" + id));
                btnAccept.Content = "Изменить";
                tbEducation.Text = eqResponse.Data[0].education;
                tbEmail.Text = eqResponse.Data[0].email;
                dpBirthday.SelectedDate = eqResponse.Data[0].birthday;
                tbGender.Text = eqResponse.Data[0].gender;
                tbInn.Text = eqResponse.Data[0].inn;
                tbMiddleName.Text = eqResponse.Data[0].middleName;
                tbName.Text = eqResponse.Data[0].name;
                tbSurname.Text = eqResponse.Data[0].surname;
                tbWorkBook.Text = eqResponse.Data[0].employmentHistory;
                tbSnils.Text = eqResponse.Data[0].snils;
                tbRequisites.Text = eqResponse.Data[0].requisites;
                tbPNumber.Text = eqResponse.Data[0].passportNumber;
                tbPSeria.Text = eqResponse.Data[0].passportSeries;
                tbNumber.Text = eqResponse.Data[0].phonenumber;
            }

        }
    }
}
