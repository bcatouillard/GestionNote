﻿using System.Windows;
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
                    Teacher.Visibility = Visibility.Collapsed;
                    break;
                case ViewEnum.studentControl:
                    
                    connect.Visibility = Visibility.Collapsed;
                    student.Visibility = Visibility.Visible;
                    Teacher.Visibility = Visibility.Collapsed;
                    student.FillInfo();
                    break;
                case ViewEnum.teacherControl:
                    connect.Visibility = Visibility.Collapsed;
                    student.Visibility = Visibility.Collapsed;
                    Teacher.Visibility = Visibility.Visible;
                    Teacher.FillInfo();
                    break;
                default:
                    connect.Visibility = Visibility.Visible;
                    student.Visibility = Visibility.Collapsed;
                    Teacher.Visibility = Visibility.Collapsed;
                    break;
            }

        }
    }
}
