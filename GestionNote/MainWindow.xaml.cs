using System.Windows;
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

        private void MainWindow_CurrentUser(object sender, CurrentUserConnectedEventArgs e)
        {
            student.FillInfo();
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
                    student.FillInfo();
                    break;
                case ViewEnum.teacherControl:
                    connect.Visibility = Visibility.Collapsed;
                    student.Visibility = Visibility.Collapsed;
                    teacher.Visibility = Visibility.Visible;
                    teacher.FillInfo();
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
