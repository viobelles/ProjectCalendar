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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjectCalendar.Авторизация
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void ExitButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void MinButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void ToolBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void LogoContainer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void UserTB_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            UserTB.Text = "";
        }

        private void PassTB_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            PassTB.Password = "";
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            Регистрация.Registration reg = new Регистрация.Registration();
            reg.Show();
            this.Close();


            //Регистрация.Registration reg = new Регистрация.Registration();
            //reg.Show();
            //// Close this window
            //this.Close();
        }
    }
}
