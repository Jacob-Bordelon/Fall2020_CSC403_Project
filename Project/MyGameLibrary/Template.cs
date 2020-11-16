using System;

namespace Fall2020_CSC403_Project.code
{
    /*This is the base "Class" a character can choose
	 */
    public abstract class Template
    {
		/// <summary>
		/// the strenght represents the base damage a character puts out per level
		/// </summary>
		public int Strength { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public int HealthPerLevel { get; set; }

		/// <summary>
		/// the MaxHealth is the maximum ammount of health the character can have
		/// </summary>
		public int MaxHealth { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public int Level { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public int Defense { get; set; }
		/// <summary>
		/// 
		/// </summary>
        public String TemplateName { get; set; }
		/// <summary>
		/// 
		/// </summary>
        public String TemplateDescription { get; set; }
		/// <summary>
		/// 
		/// </summary>
		internal Random r = new Random();
		/// <summary>
		/// 
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
		/// 
		/// </summary>
		/// <returns></returns>
		public abstract int firstAttack();
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public abstract int seccondAttack();
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public abstract int thirdAttack();
		/// <summary>
		/// 
		/// </summary>
		public void LevelUp()
        {
			Level++;
			MaxHealth = Level * HealthPerLevel;
        }

		public void AlterHealthPerLevel(int value)
        {
			HealthPerLevel += value;
			MaxHealth = Level * HealthPerLevel;
		}
		
	}
}