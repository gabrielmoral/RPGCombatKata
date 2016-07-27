using System;
namespace RPGCombatKata_csharp
{
	public class RangedFighter : IFighter
	{
		private int attackRange = 20;
		private readonly Character character;

		public double CurrentHealth
		{
			get
			{
				return character.CurrentHealth;
			}
		}

		public int CurrentLevel
		{
			get
			{
				return character.CurrentLevel;
			}
		}

		public RangedFighter(int characterLevel = 1)
		{
			this.character = new Character(characterLevel);
		}

		public void Attack(Character target, Attack attack)
		{
			character.Attack(target, attack);
		}

		public void Attack(Character target, Attack attack, Battlefield battleField)
		{
			if (!battleField.IsTargetInRange(this, target, attackRange)) return; 
			
			character.Attack(target, attack);
		}

		public void Heal(int healing)
		{
			character.Heal(healing);
		}

		public bool IsDead()
		{
			return character.IsDead();
		}
	}
}

