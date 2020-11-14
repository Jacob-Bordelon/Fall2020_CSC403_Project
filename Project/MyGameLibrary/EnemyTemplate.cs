using System;

namespace Fall2020_CSC403_Project.code
{
    public class EnemyTemplate : Template
    {
        public EnemyTemplate () 
        {
            Strength = 2;
            HealthPerLevel = 20;
            Defense = 1;
			Level = 1;
			MaxHealth = HealthPerLevel * Level;
            TemplateName = "Enemy";
            TemplateDescription = "The Enemy is the thing that goes bump in the night.";

        }

        public override int firstAttack()
        {
            return Strength;
        }

        public override int seccondAttack()
        {
            return 2*Strength;
        }

        public override int thirdAttack()
        {
            return 4*Strength;
        }
    }
}