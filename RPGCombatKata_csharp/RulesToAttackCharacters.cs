using System;

namespace RPGCombatKata_csharp
{
	public class RulesToAttackCharacters : IRulesToAttack
	{
		public bool AreFollow(IBattlefieldElement attacker, IBattlefieldElement enemy)
		{
			if (AmIHurtingMyself(attacker, enemy)) return false;

			return true;
		}

		private bool AmIHurtingMyself(IBattlefieldElement attacker, IBattlefieldElement enemy)
		{
			return attacker.Equals(enemy);
		}
	}
}

