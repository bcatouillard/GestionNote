using GestionNote.Classes;
using GestionNote.control;
using GestionNote.view;
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

namespace GestionNote.view
{
    /// <summary>
    /// Logique d'interaction pour connection.xaml
    /// </summary>
    public partial class Connection : System.Windows.Controls.UserControl
    {
        readonly control.UserControls uc = new control.UserControls();

        public Connection()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTextBox.Text;
            string password = MdpPasswordBox.Password;
            bool success = false;
            if ((bool)isStudent.IsChecked)
            {
                success = uc.SignIn(login, password,RoleEnum.student);
            }
            if ((bool)isTeacher.IsChecked)
            {
                success = uc.SignIn(login, password, RoleEnum.teacher);
            }

            if (success == true)
            {
                connect.Visibility = Visibility.Hidden;
                if ((bool)isStudent.IsChecked)
                {
                    Nav.GetInstance().GoTo(ViewEnum.studentControl);
                }
                if ((bool)isTeacher.IsChecked)
                {
                    Nav.GetInstance().GoTo(ViewEnum.teacherControl);
                }
            }
            else
            {
                MessageLabel.Content = "Les identifiants sont incorrects";
            }
        }

    }
}
