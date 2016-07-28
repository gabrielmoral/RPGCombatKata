using System;
using System.Collections.Generic;
using System.Linq;

namespace RPGCombatKata_csharp
{
	public class Character : ICharacter
	{
		private const double MinimumHealth = 0;
		public const int MaximumHealth = 1000;

		public Factions Factions { get; private set; }
		public double CurrentHealth { get; private set;}
		public int CurrentLevel { get; private set; }

		public Character(int characterLevel = 1)
		{
			this.Factions = new Factions();
			this.CurrentHealth = MaximumHealth;
			this.CurrentLevel = characterLevel;
		}

		public void Attack(IBattlefieldElement target, Attack attack)
		{	
			if (Factions.IsTheTargetMyAlly(target)) return;

			Damage damage = attack.CalculateDamage(this, target);

			target.RecieveDamage(damage);
		}

		public void Attack(IBattlefieldElement target, Attack attack, Battlefield battleField)
		{
			if (!battleField.IsTargetInRange(this, target, GetRangeAttack())) return;

			Attack(target, attack);
		}

		public void Heal(ICharacter target, int healing)
		{
			if (!Factions.IsTheTargetMyAlly(target)) return;

			target.Heal(healing);
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

		public void AddToFaction(Faction faction)
		{
			Factions.Add(faction);
		}

		protected virtual int GetRangeAttack()
		{
			return 1;
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

		private void HealMyself(int healing)
		{
			CurrentHealth += healing;

			if (this.CurrentHealth > MaximumHealth)
			{
				this.CurrentHealth = MaximumHealth;
			}
		}
	}
}

