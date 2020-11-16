using System;

namespace Fall2020_CSC403_Project.code
{
    /// <summary>
    /// The Cheetocat Template
    /// </summary>
    public class Cheetocat : Template
    {
        /// <summary>
        /// Constructor for the Cheetocat Character Template
        /// </summary>
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
        /// <summary>
		/// The attack CheetoCat uses at first level
        /// 1 in 5 critical chance for doubble damage
		/// </summary>
		/// <returns>a low ammount of damage done</returns>
        public override int FirstAttack()
        {
            int damage = (20 * Strength);
            if (r.Next(1, 5) == 5) { damage = 2 * damage; }
            return damage;
        }
        /// <summary>
		/// The attack CheetoCat uses at seccond level
        /// 1 in 5 critical chance for doubble damage
		/// </summary>
		/// <returns>a medium ammount of damage done</returns>
        public override int SeccondAttack()
        {
            int damage = (40 * Strength);
            if (r.Next(1, 5) == 5) { damage = 2 * damage; }
            return damage;
        }
        /// <summary>
		/// The attack CheetoCat uses at third level
        /// 1 in 5 critical chance for doubble damage
		/// </summary>
		/// <returns>a high ammount of damage done</returns>
        public override int ThirdAttack()
        {
            int damage = (80 * Strength);
            if (r.Next(1, 5) == 5) { damage = 2 * damage; }
            return damage;
        }
    }
}