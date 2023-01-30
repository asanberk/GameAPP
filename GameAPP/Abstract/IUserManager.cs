using System;
using System.Collections.Generic;
using System.Text;

namespace GameAPP.Abstract
{
    public interface IUserManager
    {
         void Save(IUser user);
         void Delete(IUser user);
         void Update(IUser user);
    }
}
