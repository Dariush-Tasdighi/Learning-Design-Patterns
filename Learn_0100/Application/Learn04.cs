namespace Application;

public static class Utility4 : object
{
	static Utility4()
	{
	}

	public static int Sum(int a, int b)
	{
		var result = a + b;

		return result;
	}

	/// <summary>
	/// Compile Error!
	/// </summary>
	//public int Sum(int a, int b, int c)
	//{
	//	var result = a + b + c;

	//	return result;
	//}

	public static int Sum(int a, int b, int c)
	{
		var result = a + b + c;

		return result;
	}
}
