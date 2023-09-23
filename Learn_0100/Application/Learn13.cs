namespace Learn13;

public sealed class Singleton : object
{
	private static readonly object _lockObject = new();

	private static Singleton? _instance;

	public static Singleton Instance
	{
		get
		{
			if (_instance is null)
			{
				lock (_lockObject)
				{
					_instance ??= new();
				}
			}

			return _instance;
		}
	}

	private Singleton() : base()
	{
	}
}
