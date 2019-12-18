﻿namespace GestionNote.Classes
{
    class Student : User
    {
        public int Age { get; set; }

        public string Classe { get; set; }

        public Student() { }

        public Student(string name, string login, string password, int age, string classe)
        {
            Name = name;
            Login = login;
            Password = password;
            Age = age;
            Classe = classe;
        }
    }
}