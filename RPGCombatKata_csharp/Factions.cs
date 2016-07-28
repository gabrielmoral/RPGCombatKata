using System;
using System.Collections.Generic;
using System.Linq;

namespace RPGCombatKata_csharp
{
	public class Factions
	{
		private IList<Faction> factions;

		public Factions()
		{
			factions = new List<Faction>();
		}

		public void Add(Faction faction)
		{
			factions.Add(faction);
		}

		public bool IsTheTargetMyAlly(IBattlefieldElement target)
		{
			return AreThereSharedFactions(target.Factions);
		}

		private bool AreThereSharedFactions(Factions characterFactions)
		{
			return this.factions.Intersect(characterFactions.factions).Any();
		}
	}
}

