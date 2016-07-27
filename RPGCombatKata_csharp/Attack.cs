using System;
namespace RPGCombatKata_csharp
{
	public class Attack
	{
		private readonly int damage;
		private const int levelDistance = 5;

		public Attack(int damage)
		{
			this.damage = damage;
		}

		public double CalculateDamage(ICharacter player, ICharacter target)
		{
			double multiplerDamageFactor = 0.50;

			if (EnoughMaginToBoostAttack(player, target))
			{
				return BoostDamage(multiplerDamageFactor);
			}

			if (EnoughMarginToReduceAttack(player, target))
			{
				return ReduceDamage(multiplerDamageFactor);
			}

			return damage;
		}

		private double BoostDamage(double multiplerDamageFactor)
		{
			return damage + (damage * multiplerDamageFactor);
		}

		private double ReduceDamage(double multiplerDamageFactor)
		{
			return damage - (damage * multiplerDamageFactor);
		}

		private bool EnoughMaginToBoostAttack(ICharacter player, ICharacter target)
		{
			return (player.CurrentLevel - levelDistance) >= target.CurrentLevel;
		}

		private bool EnoughMarginToReduceAttack(ICharacter player, ICharacter target)
		{
			return (target.CurrentLevel - levelDistance) >= player.CurrentLevel;
		}
	}
}

