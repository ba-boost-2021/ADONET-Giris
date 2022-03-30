using System;


public static class LookUpTypeEventManager
{
	static LookUpTypeEventManager()
	{
		LookUpTypeEvents = new LookUpTypeEvents();
	}
	public static LookUpTypeEvents LookUpTypeEvents { get; set; }
	
}
