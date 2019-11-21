using System;

namespace making_solid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Breaking SOLID!");
            PlayerManagement playerManager = new PlayerManagement();

            Fighter p1 = new Fighter(PlayerClass.Fighter, "Raegar", 14, 3, 7);
            Wizard p2 = new Wizard(PlayerClass.Wizard, "Althoif", 4, 16, 6);
            Paladin p3 = new Paladin(PlayerClass.Wizard, "Elliot Bringer of Justice", 4, 16, 6);

            playerManager.AddPlayer(p1);
            playerManager.AddPlayer(p2);
            playerManager.AddPlayer(p3);

            playerManager.DisplayPlayers();

            p2.CastDefensiveSpell();
            p1.Attack(p2);
            

            Console.WriteLine();
            playerManager.DisplayPlayers();
        }
    }
}
