namespace making_solid
{
    public interface ICastSpells
    {
         void CastAttackSpell(Player target);

         void CastDefensiveSpell();

         void CastHealingSpell(Player target);
    }

     public interface ICastHealingSpells
    {
        void CastHealingSpell(Player target);
    }

    public interface ICastAttackSpells
    {
        void CastAttackSpell(Player target);
    }

      public interface ICastDefensiveSpells
    {
        void CastDefensiveSpell();
    }
}