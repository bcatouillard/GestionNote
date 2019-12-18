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
using GestionNote.Classes;
using GestionNote.Classes.Data;
using GestionNote.view;

namespace GestionNote
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Nav.GetInstance().ChangeView += MainWindow_ChangeView;
        }

        private void MainWindow_ChangeView(object sender, ChangeViewEventArgs e)
        {
            switch (e.View)
            {
                case ViewEnum.connection:
                    connect.Visibility = Visibility.Visible;
                    student.Visibility = Visibility.Collapsed;
                    teacher.Visibility = Visibility.Collapsed;
                    break;
                case ViewEnum.studentControl:
                    
                    connect.Visibility = Visibility.Collapsed;
                    student.Visibility = Visibility.Visible;
                    teacher.Visibility = Visibility.Collapsed;
                    break;
                case ViewEnum.teacherControl:
                    connect.Visibility = Visibility.Collapsed;
                    student.Visibility = Visibility.Collapsed;
                    teacher.Visibility = Visibility.Visible;
                    break;
                default:
                    connect.Visibility = Visibility.Visible;
                    student.Visibility = Visibility.Collapsed;
                    teacher.Visibility = Visibility.Collapsed;
                    break;
            }

        }
    }
}
