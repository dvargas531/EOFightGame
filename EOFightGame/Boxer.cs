using System;
using System.Collections.Generic;
using System.Text;

namespace EOFightGame
{
	public class Boxer
	{
		private readonly string _name;

		public Boxer(string name)
		{
			_name = name;
		}

		public string Name()
		{
			return _name;
		}
	}
}
