using System.Collections.Generic;

namespace GestionNote.Classes
{
    public class Student : User
    {
        public int Age { get; set; }

        public Dictionary<MatiereEnum, int[]> Notes { get; set; }

        public Student() { }

        public Student(string name, string login, string password, int age, string classe, Dictionary<MatiereEnum, int[]> notes)
        {
            Name = name;
            Login = login;
            Password = password;
            Age = age;
            Classe = classe;
            Notes = notes;
        }
    }
}
