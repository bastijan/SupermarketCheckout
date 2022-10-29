using System;
using ConsoleManager.Interface;

namespace ConsoleManager
{
    /// <summary>
    /// The abstract class implementing the IConsoleManager interface
    /// </summary>
    /// <seealso cref="ConsoleManager.IConsoleManager" />
    public abstract class ConsoleManagerBase : IConsoleManager
    {
        public abstract void Clear();
        public abstract ConsoleKeyInfo ReadKey();
        public abstract string ReadLine();
        public abstract void Write(string value);
        public abstract void WriteLine(string value);
    }
}