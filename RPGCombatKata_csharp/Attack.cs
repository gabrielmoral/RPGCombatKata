using System;
namespace RPGCombatKata_csharp
{
	public class Attack
	{
		private readonly int damage;
		private readonly IDamageStrategy damageStrategy;
		private readonly IRulesToAttack rulesToAttack;

		public Attack(int damage, IDamageStrategy damageStrategy, IRulesToAttack rulesToAttack)
		{
			this.rulesToAttack = rulesToAttack;
			this.damageStrategy = damageStrategy;
			this.damage = damage;
		}

		public Damage CalculateDamage(IBattlefieldElement attacker, IBattlefieldElement target)
		{
			if (!rulesToAttack.AreFollow(attacker, target)) return new Damage(0);

			return damageStrategy.CalculateDamage(attacker, target, damage);
		}
	}
}

