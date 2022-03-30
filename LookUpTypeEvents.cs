using System;

public class LookUpTypeEvents
{
    public event LookUpTypeAddedEventHandler OnlookUpTypeAdded;
    public void LookUpTypeAdded()
    {
        if (OnlookUpTypeAdded != null)
        {
            OnlookUpTypeAdded.Invoke();
        }
    }
}
public delegate void LookUpTypeAddedEventHandler();