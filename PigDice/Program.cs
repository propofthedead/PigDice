using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDice
{
	class Program
	{
		static void Main(string[] args)
		{
			Random rnd = new Random();
			bool kick = false;
			int total = 0;
			while (kick == false) {
				int temp = rnd.Next(1, 7);
				total += temp;
				Console.WriteLine(temp);
				if (temp == 1) 
				{ kick = true; }
			}
			Console.WriteLine("your score is " + total);
		}
	}
}
