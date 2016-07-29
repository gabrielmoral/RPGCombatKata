using System;
using System.Collections.Generic;
using System.Linq;

namespace RPGCombatKata_csharp
{
	public class Character : BattlefieldElement
	{
		private const double MinimumHealth = 0;
		public const int MaximumHealth = 1000;

		public Character(int characterLevel = 1) : base(MaximumHealth)
		{
			this.CurrentLevel = characterLevel;
		}

		public void Attack(BattlefieldElement target, Attack attack)
		{	
			if (Factions.IsTheTargetMyAlly(target)) return;
			if (AmIHurtingMyself(this, target)) return;

			Damage damage = attack.CalculateDamage(this, target);

			target.RecieveDamage(damage);
		}

		public void Attack(BattlefieldElement target, Attack attack, Battlefield battleField)
		{
			if (!battleField.IsTargetInRange(this, target, GetRangeAttack())) return;

			Attack(target, attack);
		}

		public void Heal(Character target, int healing)
		{
			if (!Factions.IsTheTargetMyAlly(target)) return;

			target.Heal(healing);
		}

		public void Heal(int healing)
		{
			if (IsDead()) return;

			HealMyself(healing);
		}



		public void AddToFaction(Faction faction)
		{
			Factions.Add(faction);
		}

		protected virtual int GetRangeAttack()
		{
			return 1;
		}

		private void HealMyself(int healing)
		{
			CurrentHealth += healing;

			if (this.CurrentHealth > MaximumHealth)
			{
				this.CurrentHealth = MaximumHealth;
			}
		}

		private bool AmIHurtingMyself(BattlefieldElement attacker, BattlefieldElement enemy)
		{
			return attacker.Equals(enemy);
		}
	}
}

