using GestionNote.Classes;
using GestionNote.control;
using System.Windows.Controls;

namespace GestionNote.view
{
    /// <summary>
    /// Logique d'interaction pour teacherControl.xaml
    /// </summary>
    public partial class teacherControl : UserControl
    {
        UserControls uc = new UserControls();

        public teacherControl()
        {
            InitializeComponent();
        }

        public void FillInfo()
        {
            NameUser.Content += Session.GetInstance().User.Name;
            ClassUser.Content += Session.GetInstance().User.Classe;
            MatiereUser.Content += (uc.GetMatiere(Session.GetInstance().User) != MatiereEnum.nul) ? "" + uc.GetMatiere(Session.GetInstance().User) : "";
        }
    }
}
