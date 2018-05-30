using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDice
{
	class Program
	{
		Random die = new Random();
		int rolldie()
		{
			
			int roll = die.Next(1, 7);
			return roll;
		}

		void playpigdice() {
			int total = 0;
			int temp = rolldie();
			while (temp!=1) {
				
				total += temp;
				temp = rolldie();
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
