namespace InterfaceDemo
{
    internal class FileDataAccess : IDataAccess
    {
        string filePath;
        string fileData;

        public FileDataAccess() { }
        public FileDataAccess(string path)
        {
            this.filePath = path;
        }

        public string Data => fileData;

        public void GetData()
        {
            fileData = "data from file";
        }

        public bool WriteData(string data)
        {
            return true;
        }
    }
}
