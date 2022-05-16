using System;
using System.Collections.Generic;
using System.Text;
using HeroGame.Constants;

namespace HeroGame
{
	public class Attack
	{
		public string AttackName { get; set; }
		public  AttackType Type { get; set; }
		public int Damage { get; set; }

		public Attack(string name, AttackType type, int damage)
		{
			this.AttackName = name;
			this.Type = type;
			this.Damage = damage;
		}
	}
}
