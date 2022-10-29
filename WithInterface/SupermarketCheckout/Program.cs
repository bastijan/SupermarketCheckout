using Ninject;
using System.Reflection;
using ProgramManager;
using ProgramManager.Interface;

namespace MyConsoleApp
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        private static IProgramManager m_ProgramManager = null;

        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            m_ProgramManager = kernel.Get<IProgramManager>();
            m_ProgramManager.Run();
        }
    }
}
