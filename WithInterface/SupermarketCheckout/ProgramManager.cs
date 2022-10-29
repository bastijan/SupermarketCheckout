using ConsoleManager;
using SupermarketCheckout.Logic;
using ConsoleManager.Interface;

namespace ProgramManager
{
    /// <summary>
    /// Runtime
    /// </summary>
    /// <seealso cref="ProgramManager.ProgramManagerBase" />
    public class ProgramManager : ProgramManagerBase
    {
        private readonly IConsoleManager m_ConsoleManager;

        public ProgramManager(IConsoleManager consoleManager)
        {
            m_ConsoleManager = consoleManager;
        }

        /// <summary>
        /// Runs this instance.
        /// </summary>
        public override void Run()
        {
            var _sc = new ShoppingCart();
            string userInput;
            do
            {
                m_ConsoleManager.Clear();
                m_ConsoleManager.WriteLine("Scan a product:");
                m_ConsoleManager.WriteLine("1) Apple");
                m_ConsoleManager.WriteLine("2) Banana");
                m_ConsoleManager.WriteLine("3) Peach");
                m_ConsoleManager.WriteLine("\u001b[32mC) Go to checkout\u001b[0m");
                m_ConsoleManager.WriteLine("\u001b[33mX) Break and exit\u001b[0m");
                m_ConsoleManager.Write("\r\nSelect an option: ");

                userInput = m_ConsoleManager.ReadLine().ToUpper();


                switch (userInput)
                {
                    case "C":
                        _sc.ShowTotal();
                        break;
                    case "X":
                        // m_ConsoleManager.Clear();
                        break;
                    default:
                        _sc.ShowScan(userInput);
                        break;
                }
            }
            while (userInput != "X");
        }
    }
}
