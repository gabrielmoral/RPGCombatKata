using System;
namespace RPGCombatKata_csharp
{
	public class BattlefieldPosition
	{
		int position;

		public BattlefieldPosition(int position)
		{
			this.position = position;
		}

		public bool IsInRange(BattlefieldPosition targetPosition, int attackRange)
		{
			return Math.Abs(this.position - targetPosition.position) <= attackRange;
		}
}
}

