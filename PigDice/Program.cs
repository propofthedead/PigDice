using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDice
{
	class Program
	{
		void playpigdice() {
			Random rnd = new Random();
			int total = 0;
			bool kick = false;
			while (kick == false) {
				int temp = rnd.Next(1, 7);
				total += temp;
				Console.WriteLine(temp);
				if (temp == 1) { kick = true; }
			}
			Console.WriteLine("your score is " + total);
		}

		void run() {
			
			bool quit = false;
			
			while (quit == false) {
				playpigdice();
				
				Console.WriteLine("would you like to quit y/n");
				string ans = Console.ReadLine();
				ans=ans.ToUpper();
				quit = ans.StartsWith("Y");
			}
		}
		static void Main(string[] args)
		{
			(new Program()).run();
		}
	}
}
