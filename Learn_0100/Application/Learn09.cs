namespace Learn09;

public sealed class Singleton : object
{
	private static Singleton? _instance;

	public static Singleton Instance
	{
		get
		{
			_instance ??= new();

			return _instance;
		}
	}

	private Singleton() : base()
	{
	}

	// Other Members!
}
