using System;//mscorlib.dll
using Welcome; //WelcomeLibrary.dll

namespace HelloWorldExecuatbleApp
{
    internal class Program
    {
        //static int Main()
        //static int Main(string[] args)
        //static void Main(string[] args)
        static void Main()
        {
            //value-type or primitive type data type - int
            //value => value-type variable/identifier
            int value = 100;
            Console.WriteLine(value);

            CallMessenger();
            Console.WriteLine("press any key to terminate...");
            Console.ReadKey();
        }
        static void CallMessenger()
        {
            //fully qualified name
            //Welcome.Messenger messenger = new Welcome.Messenger();

            //reference-type data type - Messenger class
            //messenger =>reference-type variable/identifier
            Messenger messenger = null;
            messenger = new Messenger();
            string result = messenger.SayHello("joydip");
            Console.WriteLine(result);
        }
    }
}