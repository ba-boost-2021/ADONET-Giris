using PrivateProject;

namespace Sample
{
    class Program
    {
        static void Main()
        {
            var mt = new Mediator();
            mt.Add(3);   
            mt.Add(13);   
            mt.Add(23);   
            mt.Add(33);   
            mt.Add(43);
            mt.Remove(3);

            mt.WriteOnScreen();
        }
    }

    
}