using System;

namespace Fall2020_CSC403_Project.code
{
    //The Cheetocat Template
    public class Cheetocat : Template
    {
        public Cheetocat()
        {
            Strength = 20;
            HealthPerLevel = 30;
            Defense = 10;
			Level = 1;
			MaxHealth = HealthPerLevel * Level;
            TemplateName = "CheetoCat";
            TemplateDescription = "The CheetoCat is an extremely OP Template that can obliterate all enemies.";

        }
        public override int firstAttack()
        {
            int damage = (20 * Strength);
            if (r.Next(1, 5) == 5) { damage = 2 * damage; }
            return damage;
        }

        public override int seccondAttack()
        {
            int damage = (40 * Strength);
            if (r.Next(1, 5) == 5) { damage = 2 * damage; }
            return damage;
        }

        public override int thirdAttack()
        {
            int damage = (80 * Strength);
            if (r.Next(1, 5) == 5) { damage = 2 * damage; }
            return damage;
        }
    }
}