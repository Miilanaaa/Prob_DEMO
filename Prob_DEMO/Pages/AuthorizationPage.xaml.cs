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
using Prob_DEMO.DB;

namespace Prob_DEMO.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public class UserInfo
    {
        public static Client client { get; set; }
    }
    public partial class AuthorizationPage : Page
    {
        
        public static Client client { get; set; }
        int role;
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            //string login = loginTb.Text.Trim();
            //string password = passwordTb.Password.Trim();

            //client = new List<Client>(DbConnection.ProbDemo.Client.ToList());
            //User currentUser = users;
            //if (currentUser != null)
            //{
            //    UserInfo.User = currentUser;
            //    NavigationService.Navigate(new MenuUserPage(currentUser));
            //}
            //else
            

            
            
                NavigationService.Navigate(new MenuHomePage());
            

           
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuHomePage());
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            passwordWind passwordWindow = new passwordWind();
            if (passwordWindow.ShowDialog() == true) // Ожидаем результат
            {
                // Если пароль введен правильно, переходим на новую страницу
                NavigationService.Navigate(new Pages.MenuHomeAdminPage());
            }
        }
    }
}
