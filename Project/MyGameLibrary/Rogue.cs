using System;

namespace Fall2020_CSC403_Project.code
{
    class Rogue : Template
    {
        public Rogue()
        {
            Strength = 10;
            HealthPerLevel = 15;
            Defense = 2;
			Level = 1;
			MaxHealth = HealthPerLevel * Level;
            TemplateName = "Rogue";
            TemplateDescription = "The Rogue is very sneaky and has a large multiplier on base strength.";

        }
        public override int firstAttack()
        {
            int damage = (2*Strength) + r.Next(1, 4);
            if (r.Next(1, 20) == 20) { damage = 2 * damage; }
            return damage;
        }

        public override int seccondAttack()
        {
            int damage = (4 * Strength) + r.Next(1, 6) + r.Next(1, 6);
            if (r.Next(1, 20) == 20) { damage = 2 * damage; }
            return damage;
        }

        public override int thirdAttack()
        {
            int damage = (8 * Strength) + r.Next(1, 8) + r.Next(1, 8) + r.Next(1, 8);
            if (r.Next(1, 20) == 20) { damage = 2 * damage; }
            return damage;
        }
    }
}