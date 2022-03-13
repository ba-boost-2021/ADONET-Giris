namespace PrivateProject
{
    class Numbers
    {
        private List<int> numbers;
        public Numbers()
        {
            numbers = new List<int>();
        }

        public void Add(int n)
        {
            numbers.Add(n);
        }

        public void Remove(int n)
        {
            numbers.Remove(n);
        }

        public void Print()
        {
            Console.WriteLine(string.Join("-", numbers));
        }
    }
}