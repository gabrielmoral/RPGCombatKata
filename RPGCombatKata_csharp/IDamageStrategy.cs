using System;
namespace RPGCombatKata_csharp
{
	public interface IDamageStrategy
	{
		Damage CalculateDamage(IBattlefieldElement attacker, IBattlefieldElement target, int damage);
	}
}

