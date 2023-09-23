namespace Learn16;

// **************************************************
//public static class SingletonSqlConnection : object
//{
//	static SingletonSqlConnection()
//	{
//		_instance = new();
//	}

//	private static readonly System.Data.SqlClient.SqlConnection _instance;

//	public static System.Data.SqlClient.SqlConnection Instance
//	{
//		get
//		{
//			return _instance;
//		}
//	}
//}
// **************************************************

// **************************************************
//public static class SingletonSqlConnection : object
//{
//	static SingletonSqlConnection()
//	{
//		Instance = new();
//	}

//	public static System.Data.SqlClient.SqlConnection Instance { get; }
//}
// **************************************************

// **************************************************
//public static class SingletonObject<T> : object where T : class
//{
//	static SingletonObject()
//	{
//		//Instance = new();
//		Instance = System.Activator.CreateInstance<T>();
//	}

//	public static T Instance { get; }
//}
// **************************************************

// **************************************************
public static class SingletonObject<T> : object where T : class, new()
{
	static SingletonObject()
	{
		Instance = new();
	}

	public static T Instance { get; }
}
// **************************************************
