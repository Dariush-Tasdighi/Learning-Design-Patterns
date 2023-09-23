namespace Application;

public class Supervisor1 : object
{
	public Supervisor1() : base()
	{
	}

	// Note: Wrong Usage!
	//public int Age;

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

	// Note: Wrong Usage!
	//public string? FullName;

	//private string? _fullName;

	///// <summary>
	///// Traditional Property
	///// </summary>
	//public string? FullName
	//{
	//	get
	//	{
	//		return _fullName;
	//	}
	//	set
	//	{
	//		_fullName = value;
	//	}
	//}

	/// <summary>
	/// Modern Property
	/// </summary>
	public string? FullName { get; set; }

	public void ShowInformation()
	{
		var result =
			$"I'm {FullName} and {Age} years old.";

		System.Console.WriteLine(value: result);
	}
}
