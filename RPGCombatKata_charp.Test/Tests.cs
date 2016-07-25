using System;
using FluentAssertions;
using RPGCombatKata_csharp;
using Xunit;

namespace RPGCombatKata_charp.Test
{
	public class Tests
	{
		private int minimum_damage_attack_to_die_character = 1000;

		[Fact]
		public void When_Damage_Is_Higher_Than_Health_The_Character_Dies()
		{
			var character = new Character();

			character.RecieveDamage(minimum_damage_attack_to_die_character);

			character.IsDead().Should().BeTrue();
		}

		[Fact]
		public void When_The_Character_Is_Dead_Cannot_Be_Healed()
		{
			int healingPoints = 20;

			var character = new Character();

			character.RecieveDamage(minimum_damage_attack_to_die_character);
			character.RecieveHealing(healingPoints);

			character.IsDead().Should().BeTrue();
		}

		[Fact]
		public void Character_Cannot_Exceed_Maximum_Health()
		{
			int healingPoints = 100;

			var character = new Character();

			character.RecieveHealing(healingPoints);

			character.CurrentHealth.Should().Be(Character.MaximumHealth);
		}
	}
}

