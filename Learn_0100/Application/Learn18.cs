namespace Learn18;

public sealed class PrintManager : object
{
	static PrintManager()
	{
		Instances = new();
	}

	private static readonly object _lockObject = new();
	private static System.Collections.Hashtable Instances { get; }

	public static PrintManager GetInstance(string printerName)
	{
		if (Instances.Contains(key: printerName) == false)
		{
			lock (_lockObject)
			{
				if (Instances.Contains(key: printerName) == false)
				{
					Instances.Add(key: printerName, value: new PrintManager(printerName));
				}
			}
		}

		var instance =
			Instances[printerName] as PrintManager;

		return instance!;
	}

	private PrintManager(string name) : base()
	{
		Name = name;
	}

	public string Name { get; private init; }

	public void Print()
	{
	}

	public void GetQueueCount()
	{
	}
}
