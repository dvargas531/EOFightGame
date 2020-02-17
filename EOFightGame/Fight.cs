using System;
using System.Collections.Generic;
using System.Text;

namespace EOFightGame
{
	public class Fight
	{
		private readonly int _seconds;
		private readonly Stat _red;
		private readonly Stat _blue;

		public Fight(int seconds, Stat red, Stat blue)
		{
			_seconds = seconds;
			_red = red;
			_blue = blue;
		}

		public void Start()
		{
			int t = 0;
			while (t <= _seconds && _red.TotalHealth() > 0 && _blue.TotalHealth() > 0)
			{
				if (_red.Initiative() > _blue.Initiative())
					_blue.Punched(_red.Damage());
				else
					_red.Punched(_blue.Damage());

				t++;
			}

			if (_blue.TotalHealth() < 0)
				Console.WriteLine("Blue Corner Loses. Red Corner wins!");
			else if (_red.TotalHealth() < 0)
				Console.WriteLine("Red Corner Loses. Blue Corner wins!");
			else
				Console.WriteLine("Draw!");
		}
	}
}
