using System;

namespace Fall2020_CSC403_Project.code
{
    /*This is the base "Class" a character can choose
	 */
    public abstract class Template
    {
		//the strenght represents the base damage a character puts out per level
        public int Strength { get; set; }

		public int HealthPerLevel { get; set; }

		//the MaxHealth is the maximum ammount of health the character can have
        public int MaxHealth { get; set; }

		public int Level { get; set; }

		public int Defense { get; set; }

        public String TemplateName { get; set; }

        public String TemplateDescription { get; set; }

		internal Random r = new Random();
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

		public abstract int firstAttack();

		public abstract int seccondAttack();

		public abstract int thirdAttack();

		public void LevelUp()
        {
			Level++;
			MaxHealth = Level * HealthPerLevel;
        }

		public void StrengthUp(int value)
        {
			Strength += value;
        }
	}
}