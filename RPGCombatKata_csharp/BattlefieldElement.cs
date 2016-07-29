using System;
namespace RPGCombatKata_csharp
{
	public class BattlefieldElement
	{
		private const double MinimumHealth = 0;

		public Factions Factions { get; private set; }
		public double CurrentHealth { get; protected set; }
		public int CurrentLevel { get; protected set; }

		public BattlefieldElement(int health)
		{
			this.Factions = new Factions();
			this.CurrentHealth = health;
			this.CurrentLevel = 1;
		}

		public bool IsDead()
		{
			return this.CurrentHealth.Equals(MinimumHealth);
		}

		public void RecieveDamage(Damage damage)
		{
			double value = damage.Value;

			this.CurrentHealth -= value;

			if (this.CurrentHealth < MinimumHealth)
			{
				this.CurrentHealth = MinimumHealth;
			}
		}
	}
}

