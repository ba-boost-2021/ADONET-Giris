namespace Tratel.Contracts
{
    public class OptionDto<T>
    {
        public T Id { get; set; }
        public string Text { get; set; }

      
    }

    public class GuidOptionDto : OptionDto<Guid>
    {
        
    }

    public class NumberOptionDto : OptionDto<int>
    {

    }
    public class StringOptionDto : OptionDto<string>
    {
        public override string ToString()
        {
            return Text;
        }
    }
}
