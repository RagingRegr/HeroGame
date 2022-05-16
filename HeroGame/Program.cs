using System;
using System.Collections.Generic;
using System.Diagnostics;
using HeroGame.Constants;

namespace HeroGame
{
	internal class Program
	{
		public static List<Hero>heroes = new List<Hero>();
		public static List<Attack>physAttacks = new List<Attack>();
		public static List<Attack> magiAttacks = new List<Attack>();
		static void Main(string[] args)
		{
			physAttacks.Add(new Attack("Punch", AttackType.physical, 10));
			physAttacks.Add(new Attack("Swipe", AttackType.physical, 20));
			physAttacks.Add(new Attack("Stab", AttackType.physical, 30));

			magiAttacks.Add(new Attack("Wind", AttackType.magical, 20));
			magiAttacks.Add(new Attack("Water", AttackType.magical, 40));
			magiAttacks.Add(new Attack("Fire", AttackType.magical, 60));

			heroes.Add(new Hero("Trombone",HeroType.mage,75,physAttacks[1],magiAttacks[0],30,20));
			heroes.Add(new Hero("Trumpet", HeroType.warrior, 50, physAttacks[2], magiAttacks[1], 50, 10));
			heroes.Add(new Hero("Tuba", HeroType.warrior, 150, physAttacks[2], magiAttacks[0], 25, 25));
			heroes.Add(new Hero("French Horn", HeroType.pussy, 65, physAttacks[0], magiAttacks[2], 30, 15));
			heroes.Add(new Hero("Cornet", HeroType.mage, 30, physAttacks[2], magiAttacks[2], 10, 10));

			int heroCount=heroes.Count;
			Random random = new Random();
			Hero one = heroes[random.Next(0, heroCount)];
			Hero two = heroes[random.Next(0, heroCount)];
			while (one == two)
			{
				two = heroes[random.Next(0, heroCount)];
			}
			Hero.printInfo(one);
			Hero.printInfo(two);
		}
	}
}
