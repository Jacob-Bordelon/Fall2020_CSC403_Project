namespace Fall2020_CSC403_Project.code
{
	//The Fighter Template ADH
    public class Fighter : Template
	{
		public Fighter()
		{
			Strength = 6;
			HealthPerLevel = 20;
			Defense = 4;
			Level = 1;
			MaxHealth = HealthPerLevel * Level;
			TemplateName = "Fighter";
			TemplateDescription = "The Fighter is the master of Melee combat, big hits and the potential to Critically hit a monster.";
		}

        public override int firstAttack()
		{
			int damage = Strength + r.Next(1, 6);
			if (r.Next(1, 10) == 10) { damage = 2 * damage; }
			return damage;
		}

		public override int seccondAttack()
		{
			
			int damage = (2 * Strength) +r.Next(1, 6) + r.Next(1, 6);
			if (r.Next(1, 10) >= 9) { damage = 2 * damage; }
			return damage;
		}

		public override int thirdAttack()
		{
			int damage = (3 * Strength) + r.Next(1, 6) + r.Next(1, 6) + r.Next(1, 6);
			if (r.Next(1, 10) >= 8) { damage = 2 * damage; }
			return damage;
		}
	}

}