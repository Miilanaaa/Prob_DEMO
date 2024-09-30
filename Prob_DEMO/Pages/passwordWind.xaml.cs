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

namespace Prob_DEMO.Pages
{
    /// <summary>
    /// Логика взаимодействия для passwordWind.xaml
    /// </summary>
    public partial class passwordWind : Window
    {
        public passwordWind()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (PasswordTB.Password == "0000")
            {
                this.DialogResult = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный пароль! Попробуйте еще раз.");
            }
        }
    }
    
}
