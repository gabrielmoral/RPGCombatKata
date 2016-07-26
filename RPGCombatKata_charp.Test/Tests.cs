using System;
using FluentAssertions;
using RPGCombatKata_csharp;
using Xunit;

namespace RPGCombatKata_charp.Test
{
	public class Tests
	{
		private Attack minimum_attack_for_character_death = new Attack(1000);

		[Fact]
		public void When_Damage_Is_Higher_Than_Health_The_Character_Dies()
		{
			var player = new Character();
			var enemy = new Character();

			enemy.Attack(player, minimum_attack_for_character_death);

			player.IsDead().Should().BeTrue();
		}

		[Fact]
		public void When_The_Character_Is_Dead_Cannot_Be_Healed()
		{
			int healingPoints = 20;

			var player = new Character();
			var enemy = new Character();

			enemy.Attack(player, minimum_attack_for_character_death);
			player.Heal(healingPoints);

			player.IsDead().Should().BeTrue();
		}

		[Fact]
		public void Character_Cannot_Exceed_Maximum_Health()
		{
			int healingPoints = 100;

			var character = new Character();

			character.Heal(healingPoints);

			character.CurrentHealth.Should().Be(Character.MaximumHealth);
		}

		[Fact]
		public void Character_Can_Deal_Damage_To_Enemies()
		{
			var player = new Character();
			var enemy = new Character();

			player.Attack(enemy, minimum_attack_for_character_death);

			enemy.IsDead().Should().BeTrue();
		}

		[Fact]
		public void Character_Cannot_Deal_Damage_To_Himself()
		{
			var player = new Character();
			var enemy = new Character();

			player.Attack(player, minimum_attack_for_character_death);

			enemy.IsDead().Should().BeFalse();
		}

		[Fact]
		public void Damage_Applied_Is_Boosted_When_The_Target_Is_Five_Or_More_Levels_Below()
		{
			int characterLevel = 6;
			int futureEnemyHealth = 850;
			var attack = new Attack(100);

			var player = new Character(characterLevel);
			var enemy = new Character();

			player.Attack(enemy, attack);

			enemy.CurrentHealth.Should().Be(futureEnemyHealth);
		}

		[Fact]
		public void Damage_Applied_Is_Reduced_When_The_Target_Is_Five_Or_More_Levels_Above()
		{
			int enemyLevel = 6;
			int futureEnemyHealth = 950;
			var attack = new Attack(100);

			var player = new Character();
			var enemy = new Character(enemyLevel);

			player.Attack(enemy, attack);

			enemy.CurrentHealth.Should().Be(futureEnemyHealth);
		}	
	}
}

