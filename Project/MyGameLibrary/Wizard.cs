using System;

namespace Fall2020_CSC403_Project.code
{
    /// <summary>
    /// The Wizard Template
    /// </summary>
    public class Wizard : Template
    {
        /// <summary>
        /// Constructor for the Wizard Template
        /// </summary>
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
        /// <summary>
		/// The attack the Wizard uses at first level
		/// </summary>
		/// <returns>a low ammount of damage done Str+3d6</returns>
        public override int FirstAttack()
        {
            //str + 3d6
            int damage = Strength + r.Next(1, 6) + r.Next(1, 6) + r.Next(1, 6);
            return damage;
        }
        /// <summary>
		/// The attack the Wizard uses at seccond level
		/// </summary>
		/// <returns>a medium ammount of damage done 2*Str+5d8+5</returns>
        public override int SeccondAttack()
        {
            //2*str + 5d8 + 5
            int damage = (2*Strength) + r.Next(2, 8) + r.Next(2, 8) + r.Next(2, 8) + r.Next(2, 8) + r.Next(2, 8);
            return damage;
        }
        /// <summary>
		/// The attack the Wizard uses at third level
		/// </summary>
		/// <returns>a high ammount of damage done 4*Str+6d12+18</returns>
        public override int ThirdAttack()
        {
            //4*str + 6d12 + 18
            int damage = (4 * Strength) + r.Next(4, 12) + r.Next(4, 12) + r.Next(4, 12) + r.Next(4, 12) + r.Next(4, 12) + r.Next(4, 12);
            return damage;
        }
    }

}