using System;

public class LookUpTypeEvents
{
    public event LookUpTypeAddedEventHandler OnLookUpTypeAdded;
    public void LookUpTypeAdded()
    {
        if (OnLookUpTypeAdded != null)
        {
            OnLookUpTypeAdded.Invoke();
        }
    }
}
public delegate void LookUpTypeAddedEventHandler();