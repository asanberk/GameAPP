using GameAPP.Concrete;
using GameAPP.Entities;
using System;

namespace GameAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer();
            gamer.Id = 1;
            gamer.GamerNickName = "saboq";
            gamer.FirstName = "Sanberk";
            gamer.LastName = "Sarı";
            gamer.GamerEmail = "ahmetsanberk@gmail.com";
            
            GamerManager gamerManager= new GamerManager();

            gamerManager.Save(gamer);

        }
    }
}
