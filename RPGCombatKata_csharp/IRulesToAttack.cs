using System;
namespace RPGCombatKata_csharp
{
	public interface IRulesToAttack
	{
		bool AreFollow(IBattlefieldElement attacker, IBattlefieldElement enemy);
	}
}

