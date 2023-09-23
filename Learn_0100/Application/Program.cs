namespace Application;

internal static class Program : object
{
	static Program()
	{
	}

	private static void Main()
	{
		var number1 = 10;
		var number2 = 20;

		int result;

		// **************************************************
		var utility1 = new Utility1();

		result = utility1.Sum(a: number1, b: number2);

		System.Console.WriteLine(value: $"Sum: {result}");
		// **************************************************

		// **************************************************
		result = Utility2.Sum(a: number1, b: number2);

		System.Console.WriteLine(value: $"Sum: {result}");
		// **************************************************

		// **************************************************
		// Why we let the user to create no useful object!
		var utility2 = new Utility2();
		// **************************************************

		// **************************************************
		// User can not create any object!
		// var utility3 = new Utility3();

		result = Utility3.Sum(a: number1, b: number2);

		System.Console.WriteLine(value: $"Sum: {result}");
		// **************************************************

		// **************************************************
		// User can not create any object!
		// **************************************************
		//var utility4 = new Utility4();

		//result = Utility4.Sum(a: number1, b: number2);

		//System.Console.WriteLine(value: $"Sum: {result}");
		// **************************************************

		// **************************************************
		// *** NO COMPILE ERROR, NO RUNTIME ERROR ***********
		// **************************************************
		var instance1 = new Supervisor1();
		var instance2 = new Supervisor1();
		// ...
		// **************************************************

		// **************************************************
		// *** NO COMPILE ERROR, BUT RUNTIME ERROR **********
		// **************************************************
		var instance3 = new Supervisor2();
		var instance4 = new Supervisor2();
		// **************************************************

		// **************************************************
		// *** COMPILE ERROR ********************************
		// **************************************************
		//var instance5 = new Supervisor3();
		// **************************************************

		// **************************************************
		Supervisor3.GetInstance().Age = 20;
		Supervisor3.GetInstance().FullName = "Ali Reza Alavi";
		Supervisor3.GetInstance().ShowInformation();

		// OR

		var instance6 =
			Supervisor3.GetInstance();

		instance6.Age = 20;
		instance6.FullName = "Ali Reza Alavi";
		instance6.ShowInformation();
		// **************************************************

		// **************************************************
		// *** COMPILE ERROR ********************************
		// **************************************************
		//var instance7 = new Supervisor4();
		// **************************************************

		// **************************************************
		Supervisor4.Instance.Age = 20;
		Supervisor4.Instance.FullName = "Ali Reza Alavi";
		Supervisor4.Instance.ShowInformation();

		// OR

		var instance8 =	Supervisor4.Instance;

		instance8.Age = 20;
		instance8.FullName = "Ali Reza Alavi";
		instance8.ShowInformation();
		// **************************************************

		// **************************************************
		var instance10 = Learn16.SingletonObject<System.Data.SqlClient.SqlConnection>.Instance;
		var instance11 = Learn16.SingletonObject<System.Data.SqlClient.SqlConnection>.Instance;
		var instance12 = Learn16.SingletonObject<System.Data.SqlClient.SqlConnection>.Instance;
		// **************************************************
	}
}
