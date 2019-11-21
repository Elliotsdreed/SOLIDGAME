using System;

namespace making_solid
{

        public class Rogue : Player, ISneak
        {
                     
            public Rogue(PlayerClass playerClass, string playerName, int might, int intellect, int speed) : base (playerClass, playerName, might, intellect, speed)       
            {

            }

               public override void DisplayDetails()
            {
                Console.WriteLine($"{PlayerName} is a sneaky Rogue");
                base.DisplayDetails();
            }     
                     
                   public void Sneak()
        {
            Console.WriteLine($"{PlayerName} is sneaking");
        }
        }

}