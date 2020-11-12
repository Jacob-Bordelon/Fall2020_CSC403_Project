using System;

namespace Fall2020_CSC403_Project.code
{
    public class Wizard : Template
    {
        public Wizard()
        {
            Strength = 3;
            HealthPerLevel = 10;
            Defense = 1;
			Level = 1;
			MaxHealth = HealthPerLevel * Level;
            TemplateName = "Wizard";
            TemplateDescription = "The Wizard is a master of magic, low defense, can hit very hard.";

        }
        public override int firstAttack()
        {
            //str + 3d6
            int damage = Strength + r.Next(1, 6) + r.Next(1, 6) + r.Next(1, 6);
            return damage;
        }

        public override int seccondAttack()
        {
            //2*str + 5d8 + 5
            int damage = (2*Strength) + r.Next(2, 8) + r.Next(2, 8) + r.Next(2, 8) + r.Next(2, 8) + r.Next(2, 8);
            return damage;
        }

        public override int thirdAttack()
        {
            //4*str + 6d12 + 18
            int damage = (4 * Strength) + r.Next(4, 12) + r.Next(4, 12) + r.Next(4, 12) + r.Next(4, 12) + r.Next(4, 12) + r.Next(4, 12);
            return damage;
        }
    }

}