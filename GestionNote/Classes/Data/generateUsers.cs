using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNote.Classes.Data
{
    class GenerateUsers
    {
        // Génère un jeu d'utilisateurs
        public static void GenerateDataUsers()
        {
            Dictionary<MatiereEnum, int[]> notes = new Dictionary<MatiereEnum, int[]>
            {
                { MatiereEnum.Anglais, new int[] { 1, 3 } }
            };

            using (AppContext context = new AppContext())
            {
                Student student = new Student("eleve", "eleve", "eleve", 18, "B3", notes);
                Teacher teacher = new Teacher("teacher", "teacher", "teacher","B3",MatiereEnum.Anglais);

                context.GetStudents.Add(student);
                context.GetTeachers.Add(teacher);

                context.SaveChanges();
            }
        }

    }
}
