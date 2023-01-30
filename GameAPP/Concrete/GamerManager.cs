﻿using GameAPP.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameAPP.Concrete
{
    public class GamerManager : IUserManager
    {
        public void Delete(IUser user)
        {
            Console.WriteLine(user.FirstName+" "+ "Deleted");
        }

        public void Save(IUser user)
        {
            Console.WriteLine(user.FirstName + " " + "Saved");
        }

        public void Update(IUser user)
        {
            Console.WriteLine(user.FirstName + " " + "Updated");
        }
    }
}
