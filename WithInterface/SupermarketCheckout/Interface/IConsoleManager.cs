using System;

namespace ConsoleManager.Interface
{
    /// <summary>
    /// Defining what we are expecting from any Console Manager.
    /// </summary>
    public interface IConsoleManager
    {
        void Write(string value);
        void WriteLine(string value);
        ConsoleKeyInfo ReadKey();
        string ReadLine();
        void Clear();
    }
}