using System;
using System.Collections.Generic;
using System.Linq;

namespace RPGCombatKata_csharp
{
	public class Factions
	{
		private readonly IList<Faction> list;

		public Factions()
		{
			list = new List<Faction>();
		}

		public void Add(Faction faction)
		{
			list.Add(faction);
		}

		public bool IsTheTargetMyAlly(BattlefieldElement target)
		{
			IPartOfFactions partOfFactions = target as IPartOfFactions;

			if (partOfFactions != null)
			{
				return this.list.Intersect(partOfFactions.Factions.list).Any();
			}

			return false;
		}
	}
}

