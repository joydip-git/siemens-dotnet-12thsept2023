namespace OutstandingPersonApp.Entities
{
    public abstract class Person
    {
        public Person()
        {
        }

        public Person(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public abstract bool IsOutstanding();

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
