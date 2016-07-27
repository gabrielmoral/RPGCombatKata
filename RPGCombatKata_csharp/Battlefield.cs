using System;
using System.Collections.Generic;

namespace RPGCombatKata_csharp
{
	public class Battlefield 
	{
		private IDictionary<ICharacter, BattlefieldPosition> charactersPositions;

		public Battlefield()
		{
			charactersPositions = new Dictionary<ICharacter, BattlefieldPosition>();
		}

		public void Add(ICharacter fighter, BattlefieldPosition battlefieldPosition)
		{
			this.charactersPositions.Add(fighter, battlefieldPosition);
		}

		public bool IsTargetInRange(ICharacter character, ICharacter target, int attackRange)
		{
			BattlefieldPosition characterPosition = FindCharacter(character);
			BattlefieldPosition targetPosition = FindCharacter(target);

			return characterPosition.IsInRange(targetPosition, attackRange);
		}

		private BattlefieldPosition FindCharacter(ICharacter character)
		{
			BattlefieldPosition position;

			charactersPositions.TryGetValue(character, out position);

			return position;
		}
}
}

