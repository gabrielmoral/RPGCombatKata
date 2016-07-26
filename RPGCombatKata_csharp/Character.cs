using System;

namespace RPGCombatKata_csharp
{
	public class Character
	{
		private const double MinimumHealth = 0;
		public const int MaximumHealth = 1000;

		public double CurrentHealth { get; private set;}
		public int CurrentLevel{ get; private set; }

		public Character(int characterLevel = 1)
		{
			this.CurrentHealth = MaximumHealth;
			this.CurrentLevel = characterLevel;
		}

		public void Attack(Character enemy, Attack attack)
		{
			if (AmIHurintgMyself(enemy)) return;

			enemy.RecieveDamage(attack.CalculateDamage(this, enemy));
		}

		public void Heal(int healing)
		{
			if (IsDead()) return;

			HealMyself(healing);
		}

		public bool IsDead()
		{
			return this.CurrentHealth.Equals(MinimumHealth);
		}
		
		private void RecieveDamage(double damage)
		{
			this.CurrentHealth -= damage;
			
			if (this.CurrentHealth < MinimumHealth)
			{
				this.CurrentHealth = MinimumHealth;
			}
		}

		private void HealMyself(int healing)
		{
			CurrentHealth += healing;

			if (this.CurrentHealth > MaximumHealth)
			{
				this.CurrentHealth = MaximumHealth;
			}
		}

		private bool AmIHurintgMyself(Character enemy)
		{
			return this.Equals(enemy);
		}
}
}

