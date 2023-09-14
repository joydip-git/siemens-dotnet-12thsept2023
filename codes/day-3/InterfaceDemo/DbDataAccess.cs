namespace InterfaceDemo
{
    internal class DbDataAccess : IDataAccess
    {
        string dbConnectionString;
        string dbData;

        public DbDataAccess() { }

        public DbDataAccess(string connectionString)
        {
            this.dbConnectionString = connectionString;
        }

        public string Data
        {
            get => dbData;
            //private set => dbData = value;
        }
        public void GetData()
        {
            dbData = "data from database";
            //Data = "data from database";
        }

        public bool WriteData(string data)
        {
            return false;
        }

    }
}
