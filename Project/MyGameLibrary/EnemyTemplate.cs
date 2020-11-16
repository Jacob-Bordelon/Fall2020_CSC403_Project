using System;

namespace Fall2020_CSC403_Project.code
{
    /// <summary>
    /// The Enemy Template class
    /// This is the default Template for Battle Character
    /// This is to ensure there is an object whose methods can be called attached to the battle character
    /// </summary>
    public class EnemyTemplate : Template
    {
        /// <summary>
        /// The constructor for the Enemy Template
        /// </summary>
        public EnemyTemplate () 
        {
            Strength = 2;
            HealthPerLevel = 20;
            Defense = 6;
			Level = 1;
			MaxHealth = HealthPerLevel * Level;
            TemplateName = "Enemy";
            TemplateDescription = "The Enemy is the thing that goes bump in the night.";
        }
        /// <summary>
		/// The attack the Enemy uses at first level
		/// </summary>
		/// <returns>a low ammount of damage done Str</returns>
        public override int FirstAttack()
        {
            return Strength;
        }
        // <summary>
        /// The attack the Enemy uses at seccond level
        /// </summary>
        /// <returns>a medium ammount of damage done 2*Str</returns>
        public override int SeccondAttack()
        {
            return 2*Strength;
        }
        /// <summary>
		/// The attack the Enemy uses at third level
		/// </summary>
		/// <returns>a high ammount of damage done 4*Str</returns>
        public override int ThirdAttack()
        {
            return 4*Strength;
        }
    }
}