using GameAPP.Abstract;
using GameAPP.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameAPP.Concrete
{
    public class SalesManager : ISalesServiceManager
    {
        int wallet = 100;
        public void AddSales(IUser user, Product product, Campaign campaign)
        {

            if (campaign == null) 
            {
                if (wallet > product.Price)
                {
                    Console.WriteLine("You have Purchased the product");
                    wallet = wallet - product.Price;
                    Console.WriteLine("New balance=" + wallet);
                }
                else
                {
                    Console.WriteLine("insufficient balance");
                }
            }
            else
            {
                if (wallet > product.Price-campaign.Discount)
                {
                    Console.WriteLine("You have Purchased the product");
                    wallet = wallet - product.Price-campaign.Discount;
                    Console.WriteLine("New balance=" + wallet);
                }
                else
                {
                    Console.WriteLine("insufficient balance");
                }
            }
        }
        public void RemoveSales(IUser user, Product product, Campaign campaign)
        {
            Console.WriteLine("Your product has been sold");
            wallet= wallet+product.Price-campaign.Discount;
            Console.WriteLine("New balance="+wallet);
            
        }
    }
}
