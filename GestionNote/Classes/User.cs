using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNote.Classes
{
    class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Classe { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public User() { }

        public User(string name, string login, string password, string classe)
        {
            Name = name;
            Login = login;
            Password = password;
            Classe = classe;
        }
    }
}
