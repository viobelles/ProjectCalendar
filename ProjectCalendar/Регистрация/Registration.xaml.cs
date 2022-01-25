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
using System.Data.SqlClient;

namespace ProjectCalendar.Регистрация
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        string connectionString = @"Server=VIOBELLES; Database=UsersDB; Trusted_Connection=True;";


        public Registration()
        {
            InitializeComponent();
        }


        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            if (UserTB.Text == "" || LoginTB.Text == "" || PassTB.Password == "")
                MessageBox.Show("Заполните все облязательные поля!");
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    //sqlCon.Open();
                    //SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                    //sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //sqlCmd.Parameters.AddWithValue("@UserName", UserTB.Text.Trim());
                    //sqlCmd.Parameters.AddWithValue("@Login", LoginTB.Text.Trim());
                    //sqlCmd.Parameters.AddWithValue("@Password", PassTB.Password.Trim());
                    //sqlCmd.ExecuteNonQuery();
                    //MessageBox.Show("Регистрация выполнена успешно!");
                }
            }
        }


        //сделать функцию очистки полей после регистрации
    //    void Clear();
    //    {
    //    UserTB.Text = LoginTB.Text = PassTB.Password = "";
    //};








        private void ToolBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void MinButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void ExitButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void LogoContainer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void TextBox_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            UserTB.Text = "";
        }

        private void PassTB_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            PassTB.Password = "";
        }

        private void LoginTB_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            LoginTB.Text = "";
        }

        private void GoAuthorize_Click(object sender, RoutedEventArgs e)
        {
                Авторизация.Authorization auth = new Авторизация.Authorization();
                auth.Show();
                this.Close();

        }
    }
}
