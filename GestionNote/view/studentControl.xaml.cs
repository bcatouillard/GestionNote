using GestionNote.Classes;
using GestionNote.control;
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
        readonly UserControls uc = new UserControls();

        public studentControl() { 
            InitializeComponent();
            DataContext = this;
        }

        public void FillInfo() {
            NameUser.Content += Session.GetInstance().User.Name;
            ClassUser.Content += Session.GetInstance().User.Classe;
            AgeUser.Content += (uc.GetAge(Session.GetInstance().User) != 0) ? "" + uc.GetAge(Session.GetInstance().User) +" ans" : "";
        }
    }
}
