using System;
using System.Collections.Generic;

namespace RPGCombatKata_csharp
{
	public class Battlefield 
	{
		private IDictionary<IBattlefieldElement, BattlefieldPosition> charactersPositions;

		public Battlefield()
		{
			charactersPositions = new Dictionary<IBattlefieldElement, BattlefieldPosition>();
		}

		public void Add(ICharacter fighter, BattlefieldPosition battlefieldPosition)
		{
			this.charactersPositions.Add(fighter, battlefieldPosition);
		}

		public bool IsTargetInRange(IBattlefieldElement character, IBattlefieldElement target, int attackRange)
		{
			BattlefieldPosition characterPosition = FindCharacter(character);
			BattlefieldPosition targetPosition = FindCharacter(target);

			return characterPosition.IsInRange(targetPosition, attackRange);
		}

		private BattlefieldPosition FindCharacter(IBattlefieldElement character)
		{
			BattlefieldPosition position;

			charactersPositions.TryGetValue(character, out position);

			return position;
		}
	}
}

