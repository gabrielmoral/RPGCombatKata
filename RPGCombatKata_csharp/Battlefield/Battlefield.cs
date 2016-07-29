using System;
using System.Collections.Generic;

namespace RPGCombatKata_csharp
{
	public class Battlefield 
	{
		private IDictionary<BattlefieldElement, BattlefieldPosition> charactersPositions;

		public Battlefield()
		{
			charactersPositions = new Dictionary<BattlefieldElement, BattlefieldPosition>();
		}

		public void Add(BattlefieldElement fighter, BattlefieldPosition battlefieldPosition)
		{
			this.charactersPositions.Add(fighter, battlefieldPosition);
		}

		public bool IsTargetInRange(BattlefieldElement character, BattlefieldElement target, int attackRange)
		{
			BattlefieldPosition characterPosition = FindCharacter(character);
			BattlefieldPosition targetPosition = FindCharacter(target);

			return characterPosition.IsInRange(targetPosition, attackRange);
		}

		private BattlefieldPosition FindCharacter(BattlefieldElement character)
		{
			BattlefieldPosition position;

			charactersPositions.TryGetValue(character, out position);

			return position;
		}
	}
}

