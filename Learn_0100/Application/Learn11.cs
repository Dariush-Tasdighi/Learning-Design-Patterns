namespace Learn11;

public sealed class Singleton : object
{
	private static readonly object _lockObject = typeof(Singleton);

	private static Singleton? _instance;

	public static Singleton Instance
	{
		get
		{
			lock (_lockObject)
			{
				_instance ??= new();
			}

			return _instance;
		}
	}

	private Singleton() : base()
	{
	}
}
