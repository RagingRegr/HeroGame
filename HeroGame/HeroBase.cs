using System;
using System.Collections.Generic;
using System.Text;

namespace HeroGame
{
	public abstract class HeroBase : Object
	{
		public string Name { get; protected set; } = "Dummy";
		public  int MaxHp { get; protected set; } = 1000;
		public int CurrentHP { get; set; } = 1000;

		public Attack PhysicalAttack { get; protected set; }
		public Attack MagicalAttack { get; protected set; }
		public int PhysicalDefense { get; protected set; }
		public int MagicalDefense { get; protected set; }
	}
}
