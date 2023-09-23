namespace Learn10;

public sealed class Singleton : object
{
	private static Singleton? _instance;

	public static Singleton Instance
	{
		get
		{
			lock (typeof(Singleton))
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
