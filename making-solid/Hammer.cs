namespace making_solid
{
    public class Hammer : IMeleeWeapon
    {
        public int Damage { get; set; }

        public Hammer(int damage)
        {
            this.Damage = damage;
        }
    }
}