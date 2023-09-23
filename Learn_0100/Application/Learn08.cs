namespace Application;

public sealed class Supervisor4 : object
{
	#region Singleton Pattern
	private static Supervisor4? _instance;

	/// <summary>
	/// Lazy Loading = Lazy Initialization
	/// </summary>
	public static Supervisor4 Instance
	{
		get
		{
			_instance ??= new();

			return _instance;
		}
	}

	private Supervisor4() : base()
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
