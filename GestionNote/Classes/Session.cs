using GestionNote.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNote.Classes
{
    class Session
    {
        private static Session _instance;

        public static Session GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Session();
            }
            return _instance;
        }

        public User User { get; set; }

        private Session() { }

        protected virtual void GetUserSession(CurrentUserConnectedEventArgs e)
        {
            CurrentUser?.Invoke(this, e);
        }

        public event CurrentUserConnectedEventHandler CurrentUser;


        // Instance de Student
        public Student Student { get; set; }

        protected virtual void GetStudentSession(CurrentStudentConnectedEventArgs e)
        {
            CurrentStudent?.Invoke(this, e);
        }

        public event CurrentStudentConnectedEventHandler CurrentStudent;

        // Instance de Teacher
        public Teacher Teacher { get; set; }

        protected virtual void GetTeacherSession(CurrentTeacherConnectedEventArgs e)
        {
            CurrentTeacher?.Invoke(this, e);
        }

        public event CurrentTeacherConnectedEventHandler CurrentTeacher;
    }

    public class CurrentUserConnectedEventArgs : EventArgs
    {
        public User Usr { get; set; }
    }

    public delegate void CurrentUserConnectedEventHandler(Object sender, CurrentUserConnectedEventArgs e);

    public class CurrentStudentConnectedEventArgs : EventArgs
    {
        public Student Std { get; set; }
    }

    public delegate void CurrentStudentConnectedEventHandler(Object sender, CurrentStudentConnectedEventArgs e);

    public class CurrentTeacherConnectedEventArgs : EventArgs
    {
        public Teacher Teach { get; set; }
    }

    public delegate void CurrentTeacherConnectedEventHandler(Object sender, CurrentTeacherConnectedEventArgs e);

}
