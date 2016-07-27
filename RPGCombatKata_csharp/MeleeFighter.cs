using System;
namespace RPGCombatKata_csharp
{
	public class MeleeFighter : Character
	{
		private int attackRange = 2;

		protected override int GetRangeAttack()
		{
			return attackRange;
		}
	}
}

