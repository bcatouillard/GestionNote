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

namespace GestionNote
{
    /// <summary>
    /// Logique d'interaction pour connection.xaml
    /// </summary>
    public partial class connection : UserControl
    {
        readonly userControl uc = new userControl();

        public connection()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTextBox.Text;
            string password = MdpPasswordBox.Password;

            bool success = uc.SignIn(login, password);

            if (success == true)
            {
                connect.Visibility = Visibility.Hidden;
            }
            else
            {
                MessageLabel.Content = "Les identifiants sont incorrects";
            }
        }
    }
}
