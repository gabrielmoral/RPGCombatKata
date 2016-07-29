using System;
namespace RPGCombatKata_csharp
{
	public interface IDamageStrategy
	{
		Damage CalculateDamage(BattlefieldElement attacker, BattlefieldElement target, int damage);
	}
}

