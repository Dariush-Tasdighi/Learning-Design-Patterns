namespace Application;

public sealed class Utility3 : object
{
	static Utility3()
	{
	}

	public static int Sum(int a, int b)
	{
		var result = a + b;

		return result;
	}

	/// <summary>
	/// User can not create any instance!
	/// </summary>
	private Utility3()
	{
	}

	/// <summary>
	/// Note: I forgot to put [static]
	/// keyword for this function, but
	/// compiler did not warn me!
	/// </summary>
	public int Sum(int a, int b, int c)
	{
		var result = a + b + c;

		return result;
	}
}
