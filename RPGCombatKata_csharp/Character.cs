using System;

namespace RPGCombatKata_csharp
{
	public class Character
	{
		private const int MinimumHealth = 0;
		public const int MaximumHealth = 1000;

		private int currentLevel = 1;

		public int CurrentHealth { get; private set;}

		public Character()
		{
			this.CurrentHealth = MaximumHealth;
		}

		public void RecieveDamage(int damage)
		{
			HurtMyself(damage);
		}

		public void RecieveHealing(int healing)
		{
			if (IsDead()) return;

			HealMyself(healing);
		}

		public bool IsDead()
		{
			return this.CurrentHealth == MinimumHealth;
		}

		void HurtMyself(int damage)
		{
			this.CurrentHealth -= damage;

			if (this.CurrentHealth < MinimumHealth)
			{
				this.CurrentHealth = MinimumHealth;
			}
		}

		void HealMyself(int healing)
		{
			CurrentHealth += healing;

			if (this.CurrentHealth > MaximumHealth)
			{
				this.CurrentHealth = MaximumHealth;
			}
		}
	}
}

