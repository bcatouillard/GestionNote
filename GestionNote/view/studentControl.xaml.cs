using GestionNote.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace GestionNote.view
{
    /// <summary>
    /// Logique d'interaction pour studentControl.xaml
    /// </summary>
    public partial class studentControl : UserControl
    {
        public studentControl() { 
            InitializeComponent();
            DataContext = this; 
        }

        public void FillInfo() {
            NameUser.Content += Session.GetInstance().User.Name;
            ClassUser.Content += Session.GetInstance().User.Classe;
        }

        
    }
}
