using System;

namespace making_solid
{
    public class Paladin : Player, IAttack, ICastAttackSpells, ICastHealingSpells
    {
         protected IMeleeWeapon meleeWeapon = new Hammer(5);
         public Paladin(PlayerClass playerClass, string playerName, int might, int intellect, int speed) : base (playerClass, playerName, might, intellect, speed)       
            {
                
            }

              public void EquipWeapon(IMeleeWeapon weapon)
            {
                this.meleeWeapon = weapon;
            }


            public void Attack(Player target)
                    {
                        Console.WriteLine($"{PlayerName} is attacking {target.PlayerName} for {meleeWeapon.Damage} damage");
                        target.TakeDamage(meleeWeapon.Damage);
                    }



            public void CastDefensiveSpell()
            {
                throw new NotImplementedException();
            }

            public void CastHealingSpell(Player target)
            {
                Console.WriteLine($"Healing {target.PlayerName} for {(Intellect/10)} HP");
            }
                
            public void CastAttackSpell(Player target)
            {
                Console.WriteLine($"Attack {target.PlayerName} for {(Intellect/10)} HP");
            }

            public override void DisplayDetails()
            {
                Console.WriteLine($"{PlayerName} is into Holy Retribution and therefore is a Paladin");
                base.DisplayDetails();
            }                
    }
}