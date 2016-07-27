using System;
namespace RPGCombatKata_csharp
{
	public interface IFighter : ICharacter
	{
		void Attack(Character enemy, Attack attack, Battlefield battlefield);
	}
}

