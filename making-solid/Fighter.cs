using System;

namespace making_solid
{

        public class Fighter : Player, IAttack, IEquipWeapon
        {
            protected IMeleeWeapon meleeWeapon = new Sword(5);
                     
            public Fighter(PlayerClass playerClass, string playerName, int might, int intellect, int speed) : base (playerClass, playerName, might, intellect, speed)       
            {

            }

            public void EquipWeapon(IMeleeWeapon weapon)
            {
                this.meleeWeapon = weapon;
            }

            public override void DisplayDetails()
            {
                Console.WriteLine($"{PlayerName} is a tough Fighter");
                base.DisplayDetails();
            }                 
                     
                    public void Attack(Player target)
                    {
                        Console.WriteLine($"{PlayerName} is attacking {target.PlayerName} for {meleeWeapon.Damage} damage");
                        target.TakeDamage(meleeWeapon.Damage);
                    }
        }

}