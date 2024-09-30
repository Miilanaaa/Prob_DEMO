using Prob_DEMO.DB;
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

namespace Prob_DEMO.Pages
{
    /// <summary>
    /// Логика взаимодействия для MenuHomeAdminPage.xaml
    /// </summary>
    public partial class MenuHomeAdminPage : Page
    {
        public static List<Service> services { get; set; }
        public MenuHomeAdminPage()
        {
            InitializeComponent();
            ListItemsProd.ItemsSource = new List<Service>(DbConnection.ProbDemo.Service.ToList());

            this.DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthorizationPage());
        }
    }
}
