using System;
namespace RPGCombatKata_csharp
{
	public interface ICharacter : IBattlefieldElement
	{
		void Attack(IBattlefieldElement enemy, Attack attack, Battlefield battlefield);

		void Attack(IBattlefieldElement enemy, Attack attack);

		void Heal(int healing);
	}
}

