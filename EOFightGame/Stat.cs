using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EOFightGame
{
	public class Stat
	{
		private readonly Boxer _boxer;
		private readonly List<int> _health = new List<int>();
		private readonly int _strength;
		private readonly Random rnd = new Random();

		public Stat(int health, int strength, Boxer boxer)
		{
			_health.Add(health);
			_strength = strength;
			_boxer = boxer;
		}

		public void Punched(int damage)
		{
			Console.WriteLine(_boxer.Name() + " hit for " + damage);

			_health.Add(-damage);

			Console.WriteLine(_boxer.Name() + " total health: " + TotalHealth());
		}

		public int Damage()
		{
			int damage = _strength + rnd.Next(1, 10);

			Console.WriteLine(_boxer.Name() + " punches for " + damage);

			return damage;
		}

		public int TotalHealth()
		{
			return _health.Sum();
		}

		public int Initiative()
		{
			return Guid.NewGuid().GetHashCode();
		}
	}
}
