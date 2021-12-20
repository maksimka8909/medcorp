using HospitalAPI.Classes;
using MySql.Data.MySqlClient;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
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
            GetList();
            if(cbTables.SelectionBoxItem.ToString() == "Пользователи")
            {
                btnAdd.Visibility =  Visibility.Hidden;
                btnAdd.IsEnabled = false;
                btnEdit.Content = "Cменить статус";
                tbSearch.IsEnabled = false;
                tbSearch.Visibility = Visibility.Hidden;
                btnSearch.IsEnabled = false;
                btnSearch.Visibility = Visibility.Hidden;

            }
            else
            {
                btnAdd.Visibility = Visibility.Visible;
                btnAdd.IsEnabled = true;
                btnEdit.Content = "Изменить";
                tbSearch.IsEnabled = true;
                tbSearch.Visibility = Visibility.Visible;
                btnSearch.IsEnabled = true;
                btnSearch.Visibility = Visibility.Visible;
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Application.Current.Shutdown();
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

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (cbTables.SelectionBoxItem.ToString() != "Должности" && cbTables.SelectionBoxItem.ToString() != "Графики работы")
            {
                AddOneFieldRecordMain addOneFieldRecordMain = new AddOneFieldRecordMain();
                addOneFieldRecordMain.tableName = cbTables.SelectionBoxItem.ToString();
                addOneFieldRecordMain.Show();
                this.Hide();
            }
            else
            {
                if(cbTables.SelectionBoxItem.ToString() == "Должности" || cbTables.SelectionBoxItem.ToString() == "Графики работы")
                {
                    AddPost addPost = new AddPost();
                    addPost.tableName = cbTables.SelectionBoxItem.ToString();
                    addPost.Show();
                    this.Hide();
                }
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (btnEdit.Content.ToString() == "Cменить статус")
            {
                if (dgTableInfo.SelectedCells.Count == 0)
                {
                    string messageBoxText = "Пользователь не выбран";
                    string caption = "Ошибка";
                    MessageBoxButton button = MessageBoxButton.OK;
                    MessageBoxImage icon = MessageBoxImage.Error;
                    MessageBoxResult result;

                    result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.OK);
                }
                else
                {
                    if ((dgTableInfo.SelectedItem as UserData).role == "Админ")
                    {
                        string messageBoxText = "Пользователя с ролью админ нельзя заблокировать";
                        string caption = "Ошибка";
                        MessageBoxButton button = MessageBoxButton.OK;
                        MessageBoxImage icon = MessageBoxImage.Error;
                        MessageBoxResult result;

                        result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.OK);
                    }
                    else
                    {
                        if ((dgTableInfo.SelectedItem as UserData).status == true)
                        {
                            UserView userView = new UserView()
                            {
                                IdUser = (dgTableInfo.SelectedItem as UserData).idUser,
                                Login = (dgTableInfo.SelectedItem as UserData).login,
                                Status = false
                            };
                            var ptResponse = apiClient.Post(new RestRequest("user/update")
                                .AddJsonBody(
                                    userView
                                ));
                            var uResponse = apiClient.Get<List<UserData>>(new RestRequest("user/show"));
                            dgTableInfo.ItemsSource = uResponse.Data;
                        }
                        else
                        {
                            UserView userView = new UserView()
                            {
                                IdUser = (dgTableInfo.SelectedItem as UserData).idUser,
                                Login = (dgTableInfo.SelectedItem as UserData).login,
                                Status = true
                            };
                            var ptResponse = apiClient.Post(new RestRequest("user/update")
                                .AddJsonBody(
                                    userView
                                ));
                            var uResponse = apiClient.Get<List<UserData>>(new RestRequest("user/show"));
                            dgTableInfo.ItemsSource = uResponse.Data;
                        }
                    }
                   
                }
            }
            else
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
                    if (cbTables.SelectionBoxItem.ToString() != "Должности" && cbTables.SelectionBoxItem.ToString() != "Графики работы")
                    {
                        AddOneFieldRecordMain addOneFieldRecordMain = new AddOneFieldRecordMain();
                        switch (cbTables.SelectionBoxItem.ToString())
                        {
                            case "Типы оборудования":
                                addOneFieldRecordMain.tableName = cbTables.SelectionBoxItem.ToString();
                                addOneFieldRecordMain.id = (dgTableInfo.SelectedItem as TypeOfEquipmentData).id;
                                addOneFieldRecordMain.name = (dgTableInfo.SelectedItem as TypeOfEquipmentData).name;
                                addOneFieldRecordMain.Show();
                                this.Hide();
                                break;
                            case "Причины увольнения":
                                addOneFieldRecordMain.tableName = cbTables.SelectionBoxItem.ToString();
                                addOneFieldRecordMain.id = (dgTableInfo.SelectedItem as ReasonOfDismissalData).id;
                                addOneFieldRecordMain.name = (dgTableInfo.SelectedItem as ReasonOfDismissalData).name;
                                addOneFieldRecordMain.Show();
                                this.Hide();
                                break;

                            case "Типы исследования":
                                addOneFieldRecordMain.tableName = cbTables.SelectionBoxItem.ToString();
                                addOneFieldRecordMain.id = (dgTableInfo.SelectedItem as TypeOfResearchData).id;
                                addOneFieldRecordMain.name = (dgTableInfo.SelectedItem as TypeOfResearchData).name;
                                addOneFieldRecordMain.Show();
                                this.Hide();
                                break;

                            case "Типы отпуска":
                                addOneFieldRecordMain.tableName = cbTables.SelectionBoxItem.ToString();
                                addOneFieldRecordMain.id = (dgTableInfo.SelectedItem as TypeOfVacationData).id;
                                addOneFieldRecordMain.name = (dgTableInfo.SelectedItem as TypeOfVacationData).name;
                                addOneFieldRecordMain.Show();
                                this.Hide();
                                break;

                            case "Типы выплат":
                                addOneFieldRecordMain.tableName = cbTables.SelectionBoxItem.ToString();
                                addOneFieldRecordMain.id = (dgTableInfo.SelectedItem as PayTypeData).id;
                                addOneFieldRecordMain.name = (dgTableInfo.SelectedItem as PayTypeData).name;
                                addOneFieldRecordMain.Show();
                                this.Hide();
                                break;
                        }
                    }
                    else
                    {
                        if (cbTables.SelectionBoxItem.ToString() == "Должности" || cbTables.SelectionBoxItem.ToString() == "Графики работы")
                        {
                            AddPost addPost = new AddPost();
                            switch (cbTables.SelectionBoxItem.ToString())
                            {

                                case "Графики работы":
                                    addPost.id = (dgTableInfo.SelectedItem as WorkScheduleData).id;
                                    addPost.name = (dgTableInfo.SelectedItem as WorkScheduleData).name;
                                    addPost.secondParam = (dgTableInfo.SelectedItem as WorkScheduleData).typeOfWorkSchedule;
                                    addPost.tableName = cbTables.SelectionBoxItem.ToString();
                                    addPost.Show();
                                    this.Hide();
                                    break;

                                case "Должности":
                                    addPost.id = (dgTableInfo.SelectedItem as PostData).id;
                                    addPost.name = (dgTableInfo.SelectedItem as PostData).name;
                                    addPost.secondParam = (dgTableInfo.SelectedItem as PostData).salary.ToString();
                                    addPost.tableName = cbTables.SelectionBoxItem.ToString();
                                    addPost.Show();
                                    this.Hide();
                                    break;
                            }
                        }
                    }
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string constring = "server=194.32.248.98;user id=maxk;password = Maxk123!;persistsecurityinfo=True;database=hospital_DB";
            string file = "C:\\Users\\"+Environment.UserName+"\\backup.sql";
            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ExportToFile(file);
                        conn.Close();
                    }
                }
            }
            string messageBoxText = "Откат был успешно создан и находится по данному маршруту: C:\\Users\\" + Environment.UserName + "\\backup.sql";
            string caption = "Успех";
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.Information;
            MessageBoxResult result;

            result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.OK);
        }

        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
            string constring = "server=194.32.248.98;user id=maxk;password = Maxk123!;persistsecurityinfo=True;database=hospital_DB";
            string file = "C:\\Users\\" + Environment.UserName + "\\backup.sql";
            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ImportFromFile(file);
                        conn.Close();
                    }
                }
            }

        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            if (tbSearch.Text.Trim().Length == 0)
            {
                GetList();
            }
            else
            {
                switch (cbTables.SelectionBoxItem.ToString())
                {
                    case "Типы оборудования":
                        var eqResponse = apiClient.Get<List<TypeOfEquipmentData>>(new RestRequest("typeofequipment/search/" + tbSearch.Text));
                        dgTableInfo.ItemsSource = eqResponse.Data;
                        break;

                    case "Графики работы":
                        var wschResponse = apiClient.Get<List<WorkScheduleData>>(new RestRequest("workschedule/search/" + tbSearch.Text));
                        dgTableInfo.ItemsSource = wschResponse.Data;
                        break;

                    case "Должности":
                        var postResponse = apiClient.Get<List<PostData>>(new RestRequest("post/search/" + tbSearch.Text));
                        dgTableInfo.ItemsSource = postResponse.Data;
                        break;

                    case "Причины увольнения":
                        var rodResponse = apiClient.Get<List<ReasonOfDismissalData>>(new RestRequest("reasonofdismissal/search/" + tbSearch.Text));
                        dgTableInfo.ItemsSource = rodResponse.Data;
                        break;

                    case "Типы исследования":
                        var torResponse = apiClient.Get<List<ReasonOfDismissalData>>(new RestRequest("typeofresearch/search/" + tbSearch.Text));
                        dgTableInfo.ItemsSource = torResponse.Data;
                        break;

                    case "Типы отпуска":
                        var tovResponse = apiClient.Get<List<TypeOfVacationData>>(new RestRequest("typeofvacation/search/" + tbSearch.Text));
                        dgTableInfo.ItemsSource = tovResponse.Data;
                        break;

                    case "Типы выплат":
                        var ptResponse = apiClient.Get<List<PayTypeData>>(new RestRequest("paytype/search/" + tbSearch.Text));
                        dgTableInfo.ItemsSource = ptResponse.Data;
                        break;
                }
            }
        }
        public void GetList()
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
    }
}
