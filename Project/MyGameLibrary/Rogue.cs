using System;

namespace Fall2020_CSC403_Project.code
{
    /// <summary>
    /// The Rogue Template
    /// </summary>
    public class Rogue : Template
    {
        /// <summary>
        /// The constructor for the Rogue Template
        /// </summary>
        public Rogue()
        {
            Strength = 6;
            HealthPerLevel = 15;
            Defense = 2;
			Level = 1;
			MaxHealth = HealthPerLevel * Level;
            TemplateName = "Rogue";
            TemplateDescription = "The Rogue is very sneaky and has a large multiplier on base strength.";

        }
        /// <summary>
		/// The attack the Rogue uses at first level
        /// 1 in 20 Critical chance for doubble damage
		/// </summary>
		/// <returns>a low ammount of damage done 2*Str+1d4</returns>
        public override int FirstAttack()
        {
            int damage = (2*Strength) + r.Next(1, 4);
            if (r.Next(1, 20) == 20) { damage = 2 * damage; }
            return damage;
        }
        /// <summary>
		/// The attack the Rogue uses at seccond level
        /// 1 in 20 Critical chance for doubble damage
		/// </summary>
		/// <returns>a medium ammount of damage done 4*Str+2d6</returns>
        public override int SeccondAttack()
        {
            int damage = (4 * Strength) + r.Next(1, 6) + r.Next(1, 6);
            if (r.Next(1, 20) == 20) { damage = 2 * damage; }
            return damage;
        }
        /// <summary>
		/// The attack the Rogue uses at third level
        /// 1 in 20 Critical chance for doubble damage
		/// </summary>
		/// <returns>a high ammount of damage done 8*Str+3d8</returns>
        public override int ThirdAttack()
        {
            int damage = (8 * Strength) + r.Next(1, 8) + r.Next(1, 8) + r.Next(1, 8);
            if (r.Next(1, 20) == 20) { damage = 2 * damage; }
            return damage;
        }
    }
}