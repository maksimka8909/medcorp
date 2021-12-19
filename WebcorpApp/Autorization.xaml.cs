using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

    public partial class MainWindow : Window
    {
        private RestClient apiClient = ApiBuilder.GetInstance();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            if ((tbLogin.Text.Trim().Length != 0) && (pbPassword.Password.Trim().Length != 0))
            {
                var response = apiClient.Post<UserData>(new RestRequest("user/authorization")
                    .AddJsonBody(new
                    {
                        Login = tbLogin.Text.ToString(),
                        Password = CreateMD5(pbPassword.Password.ToString())
                    }));
                if (response.Data.role == null)
                {
                    string messageBoxText = "Пользователь не найден. Пожалуйста перепроверьте данные и попробуйте снова.";
                    string caption = "Ошибка";
                    MessageBoxButton button = MessageBoxButton.OK;
                    MessageBoxImage icon = MessageBoxImage.Error;
                    MessageBoxResult result;

                    result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.OK);
                }
                else
                {
                    if (response.Data.role == "Админ")
                    {
                        AdminMain adminMain = new AdminMain();
                        adminMain.Owner = this;
                        adminMain.Show();
                        this.Hide();
                    }

                    if (response.Data.role == "Бухгалтер")
                    {
                        AccountantMain accountantMain = new AccountantMain();
                        accountantMain.Owner = this;
                        accountantMain.Show();
                        this.Hide();
                    }

                    if (response.Data.role == "Врач")
                    {
                        DoctorMain doctorMain = new DoctorMain();
                        doctorMain.Owner = this;
                        doctorMain.Show();
                        this.Hide();
                    }

                    if (response.Data.role == "Кадровик")
                    {
                        HRMain hRMain = new HRMain();
                        hRMain.Owner = this;
                        hRMain.Show();
                        this.Hide();
                    }

                    if (response.Data.role == "Кладовщик")
                    {
                        StorekeeperMain storekeeperMain = new StorekeeperMain();
                        storekeeperMain.Owner = this;
                        storekeeperMain.Show();
                        this.Hide();
                    }

                    if (response.Data.role == "Пациент")
                    {
                        PatientMain patientMain = new PatientMain();
                        patientMain.Owner = this;
                        patientMain.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                string messageBoxText = "Поля ввода не заполнены. Пожалуйста, перепроверьте правильность ввода и повторите попытку.";
                string caption = "Ошибка";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;
                MessageBoxResult result;
                result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.OK);
            }

        }

        public static string CreateMD5(string input)
        {
            
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }
}
