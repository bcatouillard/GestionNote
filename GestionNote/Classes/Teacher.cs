using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNote.Classes
{
    class Teacher : User
    {
        public MatiereEnum Matiere { get; set; }

        public Teacher() { }

        public Teacher(string name, string login, string password, string classe, MatiereEnum matiere)
        {
            Name = name;
            Login = login;
            Password = password;
            Classe = classe;
            Matiere = matiere;
        }
    }
}
