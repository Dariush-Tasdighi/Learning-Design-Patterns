namespace Learn19;

// هنوز این درس آخر رو وقت نکردم که ویرایش کنم ولی کدهای قبلی کاملا اوکی هستند!

/// <summary>
/// The Multi-Instanced Singleton By Thread
/// We want each thread has it's connection.
/// </summary>
public sealed class ConnectionManager : object
{
	private static readonly System.Collections.Hashtable _instances;

	public static ConnectionManager Instance
	{
		get
		{
			//if (instances.Contains(System.Threading.Thread.CurrentThread) == false)
			//{
			//	instances.Add(System.Threading.Thread.CurrentThread, new ConnectionManager());
			//}

			//lock (instances)
			//{
			//	if (instances.Contains(System.Threading.Thread.CurrentThread) == false)
			//	{
			//		instances.Add(System.Threading.Thread.CurrentThread, new ConnectionManager());
			//	}
			//}

			//if (instances.Contains(System.Threading.Thread.CurrentThread) == false)
			//{
			//	lock (instances)
			//	{
			//		if (instances.Contains(System.Threading.Thread.CurrentThread) == false)
			//		{
			//			instances.Add(System.Threading.Thread.CurrentThread, new ConnectionManager());
			//		}
			//	}
			//}

			//return ((ConnectionManager)_instances[System.Threading.Thread.CurrentThread]);

			if (_instances.Contains(System.Threading.Thread.CurrentThread.ManagedThreadId) == false)
			{
				lock (_instances)
				{
					if (_instances.Contains(System.Threading.Thread.CurrentThread.ManagedThreadId) == false)
					{
						_instances.Add(System.Threading.Thread.CurrentThread.ManagedThreadId, new ConnectionManager());
					}
				}
			}

			return (ConnectionManager)_instances[System.Threading.Thread.CurrentThread.ManagedThreadId];
		}
	}

	static ConnectionManager()
	{
		_instances =
			new System.Collections.Hashtable();
	}

	private ConnectionManager()
	{
	}

	public string ConnectionString { get; set; }
}
