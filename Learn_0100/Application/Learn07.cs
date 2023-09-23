namespace Application;

public sealed class Supervisor3 : object
{
	#region Singleton Pattern
	private static Supervisor3? _instance;

	public static Supervisor3 GetInstance()
	{
		//if (_instance is null)
		//{
		//	_instance = new();
		//}

		_instance ??= new();

		return _instance;
	}

	private Supervisor3() : base()
	{
	}
	#endregion /Singleton Pattern

	private int _age;

	public int Age
	{
		get
		{
			return _age;
		}
		set
		{
			if (value >= 1 && value <= 99)
			{
				_age = value;
			}
		}
	}

	public string? FullName { get; set; }

	public void ShowInformation()
	{
		var result =
			$"I'm {FullName} and {Age} years old.";

		System.Console.WriteLine(value: result);
	}
}
