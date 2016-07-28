using System;
namespace RPGCombatKata_csharp
{
	public class Property : IBattlefieldElement
	{
		int v;

		public Property(int v)
		{
			this.v = v;
		}

		public double CurrentHealth
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public int CurrentLevel
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public Factions Factions
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public bool IsDead()
		{
			throw new NotImplementedException();
		}

		public void RecieveDamage(Damage damage)
		{
			throw new NotImplementedException();
		}
	}
}

