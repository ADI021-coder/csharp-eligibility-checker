{
    Console.WriteLine("Hello World");
    Console.WriteLine("Eligibility Checker");
    Console.Write("enter your height: ");
		string userHeight = Console.ReadLine();
		double height = Convert.ToDouble(userHeight);
		
		Console.Write("enter your age: ");
		string userAge = Console.ReadLine();
		int age = Convert.ToInt32(userAge);
		
		if ((height >= 160) && (age >= 18))
		{
			Console.WriteLine("you can enter");
		}
		else if ((height >= 160) && (age <= 18))
		{
			Console.WriteLine("you cannot enter");
		}
		else if ((height <= 160) && (age >= 18))
		{
			Console.WriteLine("you cannot enter");
		}
		else if ((height <= 160) && (age <= 18))
		{
			Console.WriteLine("f off!");
		}
}