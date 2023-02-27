using System;
using GameProject.Concrate;
using GameProject.Entities;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 1998, FirstName = "Tahir", LastName = "Güngör", IdentityNumber= 1234 });
        }
    }
}
