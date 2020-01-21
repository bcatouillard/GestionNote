using GestionNote.Classes;
using GestionNote.Classes.Data;
using GestionNote.control;
using System.Collections.Generic;
using System.Windows.Controls;

namespace GestionNote.view
{
    /// <summary>
    /// Logique d'interaction pour teacherControl.xaml
    /// </summary>
    public partial class TeacherControl : UserControl
    {
        readonly UserControls uc = new UserControls();

        public TeacherControl()
        {
            InitializeComponent();
        }

        // Méthode qui remplit les labels concernant les informations de l'utilisateur ainsi que la DataGrid
        public void FillInfo()
        {
            NameUser.Content += Session.GetInstance().User.Name;
            ClassUser.Content += Session.GetInstance().User.Classe;
            MatiereUser.Content += (uc.GetMatiere(Session.GetInstance().User) != MatiereEnum.nul) ? "" + uc.GetMatiere(Session.GetInstance().User) : "";

            Teacher teach = Session.GetInstance().Teacher;
            List<Student> studentList = new List<Student>();

            using (AppContext context = new AppContext())
            {
                foreach (Student student in context.GetStudents)
                {
                    if (student.Classe == teach.Classe)
                    {
                        studentList.Add(student);
                    }
                }
            }

            List<int[]> notesList = new List<int[]>();
            foreach (Student student in studentList)
            {
                int[] noteValue;
                if (student.Notes.TryGetValue(teach.Matiere, out noteValue))
                {
                    notesList.Add(noteValue);
                }
            }
        }
    }
}
