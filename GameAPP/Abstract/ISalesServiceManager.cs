using GameAPP.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameAPP.Abstract
{
    public  interface ISalesServiceManager
    {
        void AddSales(IUser user,Product product,Campaign campaign);
        void  RemoveSales(IUser user,Product product,Campaign campaign);
    }
}
