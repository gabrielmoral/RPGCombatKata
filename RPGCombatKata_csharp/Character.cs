using System;

namespace RPGCombatKata_csharp
{
	public class Character : ICharacter
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

		public void Attack(Character target, Attack attack)
		{
			if (AmIHurtingMyself(target)) return;

			target.RecieveDamage(attack.CalculateDamage(this, target));
		}

		public void Attack(Character target, Attack attack, Battlefield battleField)
		{
			if (!battleField.IsTargetInRange(this, target, GetRangeAttack())) return;

			Attack(target, attack);
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

		protected virtual int GetRangeAttack()
		{
			return 1;
		}

		//TODO
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

		private bool AmIHurtingMyself(ICharacter enemy)
		{
			return this.Equals(enemy);
		}

	}
}

