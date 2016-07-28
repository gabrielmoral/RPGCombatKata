using System;
namespace RPGCombatKata_csharp
{
	public class DamagePropertiesStrategy : IDamageStrategy
	{
		public Damage CalculateDamage(IBattlefieldElement player, IBattlefieldElement target, int value)
		{
			return new Damage(value);
		}
	}
}

