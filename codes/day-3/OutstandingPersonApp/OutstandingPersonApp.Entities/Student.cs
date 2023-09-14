namespace OutstandingPersonApp.Entities
{
    public class Student : Person
    {
        public Student() { }

        public Student(string name, string branch, double marks) : base(name)
        {
            Branch = branch;
            Marks = marks;
        }

        public string Branch { get; set; }
        public double Marks { get; set; }
        public override bool IsOutstanding()
        {
            return Marks >= 85;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {Branch}, {Marks}";
        }
    }
}
