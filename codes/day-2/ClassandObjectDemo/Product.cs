namespace ClassandObjectDemo
{
    class Product
    {
        #region data members
        private string name;
        private string description;
        //readonly instance data member
        //can be assigned through instance constructors
        private readonly int id;
        private double price;
        public const string COMPANY_NAME = "H&G";
        #endregion

        #region constructors
        public Product() { }

        public Product(string name, string description, int id, double price)
        {
            this.name = name;
            this.description = description;
            this.id = id;
            this.price = price;
        }
        #endregion

        #region properties        
        //public int GetId(){return this.id;}

        //read-only property
        //public int Id
        //{
        //    get { return id; }
        //}
       
        //public int Id
        //{
        //    get => id;
        //}

        public int Id => id;

        //property function or property => set and get accessors
        public double Price
        {
            //public double GetPrice() {
            get
            {
                return this.price;
            }
            //public void SetPrice(double value)
            set
            {
                this.price = value;
            }
        }

        public string Name
        {
            set => this.name = value;
            get => this.name;
        }

        public string Description
        {
            set => this.description = value;
            get => this.description;
        }
        #endregion

        #region methods
        public string GetInformation()
        {
            //string interpolation
            return $"Name: {this.name}, Id:{id}, Price:{price}, Description: {description}";
        }
        #endregion
    }
}
