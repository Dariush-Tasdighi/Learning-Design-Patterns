namespace Application;

public class Supervisor2 : object
{
	static Supervisor2()
	{
		_instanceCount = 0;
	}

	private static int _instanceCount;

	public Supervisor2() : base()
	{
		if (_instanceCount > 0)
		{
			var errorMessage =
				"No more than one object permitted!";

			throw new System.Exception(message: errorMessage);
		}

		_instanceCount++;
	}

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
