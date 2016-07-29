using System;
namespace RPGCombatKata_csharp
{
	public class DamageElementsStrategy : IDamageStrategy
	{
		public Damage CalculateDamage(BattlefieldElement player, BattlefieldElement target, int value)
		{
			return new Damage(value);
		}
	}
}

