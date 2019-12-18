using GestionNote.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNote
{
    public class userControl
    {
        public bool SignIn(string log, string pswd)
        {
            using (AppContext context = new AppContext())
            {
                bool success = false;
                User usr = new User();
                IEnumerable<User> userList = context.GetUsers.Where((user) => user.Login == log);
                foreach(User user in userList)
                {
                    if(user.Login == log && user.Password == pswd)
                    {
                        usr = user;
                        success = true;
                    }
                    else
                    {
                        success = false;
                    }
                }
                if(success == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
