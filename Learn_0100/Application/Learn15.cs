namespace Learn15;

/// <summary>
/// It is quite lazy, thread-safe without using locks.
/// </summary>
public sealed class Singleton : object
{
	// Static Constructor is Thread Safe!
	// Explicit static constructor to tell
	// C# compiler do not mark type as [BeforeFieldInit]
	static Singleton()
	{
		_instance = new Singleton();
	}

	private static readonly Singleton _instance;

	public static Singleton Instance
	{
		get
		{
			return _instance;
		}
	}

	private Singleton() : base()
	{
	}
}
