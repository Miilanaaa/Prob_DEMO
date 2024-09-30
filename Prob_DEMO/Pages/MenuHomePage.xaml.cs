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
    /// Логика взаимодействия для MenuHomePage.xaml
    /// </summary>
    public partial class MenuHomePage : Page
    {
        public static List<Service> services { get; set; }
        public MenuHomePage()
        {
            InitializeComponent();
            ListItemsProd.ItemsSource = new List<Service>(DbConnection.ProbDemo.Service.ToList());

            this.DataContext = this;

            //if()
            //{
            //    AddProduct.Visibility = Visibility.Visible;
            //    AddProductBOR.Visibility = Visibility.Visible;
            //    deleteBtn.Visibility = Visibility.Visible;
            //    deleteBtnBOR.Visibility = Visibility.Visible;
            //    changeBtn.Visibility = Visibility.Visible;
            //    changeBtnBOR.Visibility = Visibility.Visible;
                
            //}
            //else
            //{
            //    AddProduct.Visibility = Visibility.Hidden;
            //    AddProductBOR.Visibility = Visibility.Hidden;
            //    deleteBtn.Visibility = Visibility.Hidden;
            //    deleteBtnBOR.Visibility = Visibility.Hidden;
            //    changeBtn.Visibility = Visibility.Hidden;
            //    changeBtnBOR.Visibility = Visibility.Hidden;
                
            //}
        }

        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddPage());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthorizationPage());
        }
    }
}
