namespace PrivateProject;

public class Mediator
{
    public Mediator()
    {
        var numbers = new Numbers();
        Add = numbers.Add;
        Remove = numbers.Remove;
        WriteOnScreen = numbers.Print;
    }
    public ManipulateList Add { get; set; }
    public ManipulateList Remove { get; set; }
    public ExtractOutput WriteOnScreen { get; set; }
}
