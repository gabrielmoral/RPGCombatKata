using System;
namespace RPGCombatKata_csharp
{
	public class RangedFighter : Character
	{
		private int attackRange = 20;

		protected override int GetRangeAttack()
		{
			return attackRange;
		}
	}
}

