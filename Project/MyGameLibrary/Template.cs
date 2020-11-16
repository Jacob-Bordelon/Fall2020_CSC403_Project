using System;

namespace Fall2020_CSC403_Project.code
{
	/// <summary>
	///  This is the base "Class" a character can choose
	///  called Template because Class is already language used by c#
	/// </summary>
	public abstract class Template
    {
		/// <summary>
		/// the strenght represents the base damage a character puts out per level
		/// </summary>
		public int Strength { get; set; }
		/// <summary>
		/// the ammount of health you have per level
		/// </summary>
		public int HealthPerLevel { get; set; }
		/// <summary>
		/// the MaxHealth is the maximum ammount of health the character can have
		/// </summary>
		public int MaxHealth { get; set; }
		/// <summary>
		/// Level is the level of the template
		/// </summary>
		public int Level { get; set; }
		/// <summary>
		/// Defense is the ammount incoming damage is reduced by
		/// </summary>
		public int Defense { get; set; }
		/// <summary>
		/// Template name is the name of the template
		/// </summary>
        public String TemplateName { get; set; }
		/// <summary>
		/// Template Desctiption is a description of the template
		/// </summary>
        public String TemplateDescription { get; set; }
		/// <summary>
		/// r is a random number generator for getting random integers
		/// </summary>
		internal Random r = new Random();
		/// <summary>
		/// The default values for a template
		/// </summary>
		public Template()
		{
			Strength = 1;

			Level = 1;

			HealthPerLevel = 10;

			MaxHealth = HealthPerLevel * Level;

			Defense = 1; 

			TemplateName = "default name";

			TemplateDescription = "default description";

		}
		/// <summary>
		/// The attack used at first level
		/// </summary>
		/// <returns>a low ammount of damage done</returns>
		public abstract int FirstAttack();
		/// <summary>
		/// The attack used at seccond level
		/// </summary>
		/// <returns>a medium ammount of damage done</returns>
		public abstract int SeccondAttack();
		/// <summary>
		/// The attack used at third level
		/// </summary>
		/// <returns>a high ammount of damage done</returns>
		public abstract int ThirdAttack();
		/// <summary>
		/// increments the characters level and increases the max health of the character
		/// </summary>
		public void LevelUp()
        {
			Level++;
			MaxHealth = Level * HealthPerLevel;
        }
		/// <summary>
		/// Increases the ammount of health you gain per level
		/// </summary>
		/// <param name="value">the ammount the health per level will increase</param>
		public void AlterHealthPerLevel(int value)
        {
			HealthPerLevel += value;
			MaxHealth = Level * HealthPerLevel;
		}
		/// <summary>
		/// Increases the defense of the character
		/// </summary>
		/// <param name="value">the ammount the defense will increase</param>
		public void AlterDefense(int value)
        {
			Defense += value;
        }
	}
}