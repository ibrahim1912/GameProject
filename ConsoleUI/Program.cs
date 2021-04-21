using System;

namespace GamerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer {BirthYear=1992,FirstName="İbrahim",IdentityNumber=1723456} );

        }
    }
}
