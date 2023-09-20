namespace DelegateImplementation
{
    internal class Logic
    {
        public bool IsEven(int num)
        {
            return (num % 2 == 0);
        }
        public bool IsOdd(int num)
        {
            return (num % 2 != 0);
        }
    }
}
