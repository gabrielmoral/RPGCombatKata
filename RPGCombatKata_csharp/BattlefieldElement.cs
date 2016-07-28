using System;
namespace RPGCombatKata_csharp
{
	public interface IBattlefieldElement
	{	
		double CurrentHealth { get; }

		int CurrentLevel { get; }

		Factions Factions { get; }

		void RecieveDamage(Damage damage);

		bool IsDead();
}
}

