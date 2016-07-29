using System;
namespace RPGCombatKata_csharp
{
	public class Attack
	{
		private readonly int damage;
		private readonly IDamageStrategy damageStrategy;

		public Attack(int damage, IDamageStrategy damageStrategy)
		{
			this.damageStrategy = damageStrategy;
			this.damage = damage;
		}

		public Damage CalculateDamage(BattlefieldElement attacker, BattlefieldElement target)
		{
			return damageStrategy.CalculateDamage(attacker, target, damage);
		}
	}
}

