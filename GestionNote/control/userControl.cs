﻿using GestionNote.Classes;
using GestionNote.Classes.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNote.control
{
    public class userControl
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