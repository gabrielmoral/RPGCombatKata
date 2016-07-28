using System;
namespace RPGCombatKata_csharp
{
	public class DamageCharactersStrategy : IDamageStrategy
	{
		private const int levelDistance = 5;

		public Damage CalculateDamage(IBattlefieldElement player, IBattlefieldElement target, int value)
		{
			double multiplerDamageFactor = 0.50;

			if (EnoughMaginToBoostAttack(player, target))
			{
				return new Damage(BoostDamage(multiplerDamageFactor, value));
			}

			if (EnoughMarginToReduceAttack(player, target))
			{
				return new Damage(ReduceDamage(multiplerDamageFactor, value));
			}

			return new Damage(value);
		}

		private double BoostDamage(double multiplerDamageFactor, int damage)
		{
			return damage + (damage * multiplerDamageFactor);
		}

		private double ReduceDamage(double multiplerDamageFactor, int damage)
		{
			return damage - (damage * multiplerDamageFactor);
		}

		private bool EnoughMaginToBoostAttack(IBattlefieldElement player, IBattlefieldElement target)
		{
			return (player.CurrentLevel - levelDistance) >= target.CurrentLevel;
		}

		private bool EnoughMarginToReduceAttack(IBattlefieldElement player, IBattlefieldElement target)
		{
			return (target.CurrentLevel - levelDistance) >= player.CurrentLevel;
		}
	}
}

