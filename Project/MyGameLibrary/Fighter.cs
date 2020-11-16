namespace Fall2020_CSC403_Project.code
{
	/// <summary>
	/// The Fighter Template 
	/// </summary>
	public class Fighter : Template
	{
		/// <summary>
		/// The constructor for the Fighter Template
		/// </summary>
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
		/// <summary>
		/// The attack The fighter uses at first level
		/// 1 in 10 critical chance for dodubble damage
		/// </summary>
		/// <returns>a low ammount of damage done Str+1d6</returns>
		public override int FirstAttack()
		{
			int damage = Strength + r.Next(1, 6);
			if (r.Next(1, 10) == 10) { damage = 2 * damage; }
			return damage;
		}
		/// <summary>
		/// The attack The fighter uses at seccond level
		/// 2 in 10 critical chance for dodubble damage
		/// </summary>
		/// <returns>a medium ammount of damage done 2*str+2d6</returns>
		public override int SeccondAttack()
		{
			
			int damage = (2 * Strength) +r.Next(1, 6) + r.Next(1, 6);
			if (r.Next(1, 10) >= 9) { damage = 2 * damage; }
			return damage;
		}/// <summary>
		 /// The attack The fighter uses at third level
		 /// 3 in 10 critical chance for dodubble damage
		 /// </summary>
		 /// <returns>a high ammount of damage done 3*Str+3d6</returns>
		public override int ThirdAttack()
		{
			int damage = (3 * Strength) + r.Next(1, 6) + r.Next(1, 6) + r.Next(1, 6);
			if (r.Next(1, 10) >= 8) { damage = 2 * damage; }
			return damage;
		}
	}

}