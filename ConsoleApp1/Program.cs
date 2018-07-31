using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ProtectProcess.ProtectProcess.Protect();
            Console.WriteLine("You can't kill me. Only an admin can kill me...");
#if DEBUG
            Console.ReadLine();
#endif
        }
    }
}
