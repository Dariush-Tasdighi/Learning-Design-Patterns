namespace Learn19;

/// <summary>
/// The Multi-Instanced Singleton By Thread
/// We want each thread has it's connection.
/// </summary>
public sealed class ConnectionManager : object
{
	static ConnectionManager()
	{
		_instances =
			new System.Collections.Hashtable();
	}

	private static readonly object _lockObject = new();
	private static readonly System.Collections.Hashtable _instances;
	
	public static ConnectionManager Instance
	{
		get
		{
			// **************************************************
			//if (_instances.Contains(key: System.Threading.Thread.CurrentThread) == false)
			//{
			//	var instance = new ConnectionManager();

			//	_instances.Add(key: System.Threading.Thread.CurrentThread, instance);
			//}

			//// روش احمقانه
			////var result = (ConnectionManager)_instances[System.Threading.Thread.CurrentThread];

			//var result = _instances[System.Threading.Thread.CurrentThread] as ConnectionManager;

			//return result!;
			////return result;
			// **************************************************

			// **************************************************
			//lock (_lockObject)
			//{
			//	if (_instances.Contains(key: System.Threading.Thread.CurrentThread) == false)
			//	{
			//		var instance = new ConnectionManager();

			//		_instances.Add(key: System.Threading.Thread.CurrentThread, instance);
			//	}
			//}

			//var result = _instances[System.Threading.Thread.CurrentThread] as ConnectionManager;

			//return result!;
			// **************************************************

			// **************************************************
			if (_instances.Contains(key: System.Threading.Thread.CurrentThread) == false)
			{
				lock (_lockObject)
				{
					if (_instances.Contains(key: System.Threading.Thread.CurrentThread) == false)
					{
						var instance = new ConnectionManager();

						_instances.Add(key: System.Threading.Thread.CurrentThread, instance);
					}
				}
			}

			var result = _instances[System.Threading.Thread.CurrentThread] as ConnectionManager;

			return result!;
			// **************************************************
		}
	}

	private ConnectionManager()
	{
	}

	public string? ConnectionString { get; set; }
}
