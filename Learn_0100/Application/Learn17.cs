namespace Learn17;

/// <summary>
/// The Multi-Instanced Singleton Pattern By Value!
/// We have some printers for managing.
/// </summary>
public sealed class PrintManager : object
{
	static PrintManager()
	{
		_instances = new();
	}

	private static readonly object _lockObject = new();
	private static readonly System.Collections.Hashtable? _instances;

	public static PrintManager GetInstance(string printerName)
	{
		//if (_instances.Contains(key: printerName) == false)
		//{
		//	_instances.Add(key: printerName, value: new PrintManager(printerName));
		//}

		//lock (_lockObject)
		//{
		//	if (_instances.Contains(key: printerName) == false)
		//	{
		//		_instances.Add(key: printerName, value: new PrintManager(printerName));
		//	}
		//}

		if (_instances.Contains(key: printerName) == false)
		{
			lock (_lockObject)
			{
				if (_instances.Contains(key: printerName) == false)
				{
					_instances.Add(key: printerName, value: new PrintManager(printerName));
				}
			}
		}

		var instance = _instances[printerName] as PrintManager;
		//var instance = (PrintManager)_instances[printerName];

		return instance!;
		//return instance;
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
