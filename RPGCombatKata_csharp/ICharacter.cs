using System;
namespace RPGCombatKata_csharp
{
	public interface ICharacter
	{
		double CurrentHealth { get; }

		int CurrentLevel { get; }

		void Attack(Character enemy, Attack attack, Battlefield battlefield);

		void Attack(Character enemy, Attack attack);

		void Heal(int healing);

		bool IsDead();
	}
}

