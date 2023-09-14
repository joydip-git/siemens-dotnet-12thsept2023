using System.Windows.Markup;

namespace InterfaceDemo
{
    interface IDataAccess
    {
        //const int value = 100;
        void GetData();
        bool WriteData(string data);
        string Data { get; }
    }
}
