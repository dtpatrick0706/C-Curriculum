using System;

class Program {
  public static void Main () {
    Console.WriteLine("What day of the week is it?");
		// int day = 1;
		// int day = Convert.ToInt32(Console.ReadLine());
		string day = Console.ReadLine();
		switch (day) 
		{
		case "Mon" or "Monday" or "monday" or "mon" or "M" or "m":
			Console.WriteLine("Today is: Monday");
			Console.WriteLine("Todays Schedule: Go swimming with daughter.");
			break;
		case "Tues" or "Tuesday" or "tuesday" or "tues" or "T" or "t":
			Console.WriteLine("Today is: Tuesday");
			Console.WriteLine("Todays Schedule: Play badminton with Kevin.");
			break;
		case "Wed" or "Wednesday" or "wednesday" or "wed" or "W" or "w":
			Console.WriteLine("Today is: Wednesday");
			Console.WriteLine("Todays Schedule: Play Genshin impact with Doyeon");
			break;
		case "Thur" or "Thursday" or "thursday" or "thurs" or "Th" or "th":
			Console.WriteLine("Today is: Thursday");
			Console.WriteLine("Todays Schedule: Eat delicious food with Chomin.");
			break;
		case "Fri" or "Friday" or "friday" or "fri" or "F"or "f":
			Console.WriteLine("Today is: Friday");
			Console.WriteLine("Todays Schedule: Develop new game with SJ.");
			break;
		case "Sat" or "Saturday" or "saturday" or "sat" or "Sa" or "sa":
			Console.WriteLine("Today is: Saturday");
			Console.WriteLine("Todays Schedule: Go skydiving with Danny");
			break;
		case "Sun" or "Sunday" or "sunday" or "sun" or "Su" or "su":
			Console.WriteLine("Today is: Sunday");
			Console.WriteLine("Todays Schedule: Go to soccer game with J");
			break;
		}
  }
}