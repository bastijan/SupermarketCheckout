using System;

namespace ConsoleManager
{
    /// <summary>
    /// Default Console Manager implementation which wraps System.Console and is actually used at runtime.
    /// </summary>
    /// <seealso cref="ConsoleManager.ConsoleManagerBase" />
    public class ConsoleManager : ConsoleManagerBase
    {
        public override void Clear()
        {
            Console.Clear();
        }

        public override ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey();
        }

        public override string ReadLine()
        {
            return Console.ReadLine();
        }

        public override void Write(string value)
        {
            Console.Write(value);
        }

        public override void WriteLine(string value)
        {
            Console.WriteLine(value);
        }
    }
}