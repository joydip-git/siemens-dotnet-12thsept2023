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
            //fully qualified name
            //Welcome.Messenger messenger = new Welcome.Messenger();

            Messenger messenger = new Messenger();
            string result = messenger.SayHello("joydip");
            Console.WriteLine(result);
            Console.WriteLine("press any key to terminate...");
            Console.ReadKey();
        }
    }
}