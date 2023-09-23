namespace Learn14;

// Learning Before Field Init
// What is difference between below classes?

class Class1
{
	private static object _instance = new();
}

class Class2
{
	private static object _instance;

	/// <summary>
	/// Thread Safe
	/// </summary>
	static Class2()
	{
		_instance = new object();
	}
}
