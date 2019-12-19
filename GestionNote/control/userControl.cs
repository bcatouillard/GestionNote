using GestionNote.Classes;
using GestionNote.Classes.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNote.control
{
    public class UserControls
    {
        public bool SignIn(string log, string pswd, RoleEnum list)
        {
            using (Classes.Data.AppContext context = new Classes.Data.AppContext())
            {
                bool success = false;
                IEnumerable<User> userList;
                User usr = new User();
                if (list == RoleEnum.student)
                {
                    userList = context.GetStudents.Where((user) => user.Login == log);
                }
                else
                {
                    userList = context.GetTeachers.Where((user) => user.Login == log);
                }
                foreach(User user in userList)
                {
                    if(user.Login == log && user.Password == pswd)
                    {
                        usr = user;
                        success = true;
                        Session.GetInstance().User = user;
                    }
                    else
                    {
                        success = false;
                    }
                }
                return success;
            }
        }

        public MatiereEnum GetMatiere(User usr)
        {
            using (Classes.Data.AppContext context = new Classes.Data.AppContext())
            {
                IEnumerable<Teacher> teacherList = context.GetTeachers.Where((user) => user.Login == usr.Login);

                foreach (Teacher teacher in teacherList)
                {
                    if (teacher.Login == usr.Login)
                    {
                        return teacher.Matiere;
                    }
                }
            }
            return MatiereEnum.nul;
        }

        public int GetAge(User usr)
        {
            using (Classes.Data.AppContext context = new Classes.Data.AppContext())
            {
                IEnumerable<Student> studentList = context.GetStudents.Where((user) => user.Login == usr.Login);

                foreach (Student student in studentList)
                {
                    if (student.Login == usr.Login)
                    {
                        return student.Age;
                    }
                }
            }
            return 0;
        }
    }
}
