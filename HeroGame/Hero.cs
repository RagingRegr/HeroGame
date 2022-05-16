using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using HeroGame.Constants;

namespace HeroGame
{
	public class Hero
	{
		private const int MinDelay = 1000;
		private const int MaxDelay = 5000;
		private const int CritChance = 2;
		public HeroType Type { get; private set; } = HeroType.none;

		public string name;
		private int currenthp;
		private int PhysicalDefense;
		private int MagicalDefense;
		public Attack PhysicalAttack;
		public Attack MagicalAttack;
		public Hero(string name, HeroType type, int maxHP, Attack physicalAttack, Attack magicalAttack, int physicalDefense, int magicalDefense)
		{
			this.name = name;
			this.Type = type;
			this.MaxHP = maxHP;
			this.Currenthp = maxHP;
			this.PhysicalAttack = physicalAttack;
			this.MagicalAttack = magicalAttack;
			this.PhysicalDefense = physicalDefense;
			this.MagicalDefense = magicalDefense;
		}

		public int Currenthp;
		public int MaxHP { get; private set; }
		public static void printInfo(Hero hero)
		{
			Console.WriteLine($"Hero: {hero.name} Class: {hero.Type} Max HP: {hero.MaxHP} physDMG: {hero.PhysicalAttack.Damage} magDMG: {hero.MagicalAttack.Damage} physDEF: {hero.PhysicalDefense} magDEF: {hero.MagicalDefense}");
		}
		public static int Randomizer(int min, int max)
		{
			Random rand = new Random();
			int randNum = rand.Next(min, max);
			return randNum;
		}

		public static void Battle(Hero one, Hero two)
		{
			while (one.Currenthp > 0 && two.Currenthp > 0)
			{
				Stopwatch timeone = new Stopwatch();
				timeone.Start();
				Stopwatch timetwo = new Stopwatch();
				timetwo.Start();

			}
		}

		public static void Fight(Hero hero, Stopwatch stopwatch)
		{
			int type = Randomizer(0, 1);
			int crit = Randomizer(1, 100);
			int dmg, def, defcool = Randomizer(1000, 10000);
			string att;
			if (type == 0)
			{

			}

		}
	}
}