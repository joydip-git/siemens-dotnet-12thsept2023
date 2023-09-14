namespace OutstandingPersonApp.Entities
{
    public class Professor : Person
    {
        public Professor()
        {
        }

        public Professor(string name, string department, int booksPublished) : base(name)
        {
            Department = department;
            BooksPublsihed = booksPublished;
        }

        public string Department { get; set; }
        public int BooksPublsihed { get; set; }

        public override bool IsOutstanding()
        {
            return BooksPublsihed >= 5 ? true : false;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {Department}, {BooksPublsihed}";
        }
    }
}
