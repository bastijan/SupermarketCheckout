using Ninject.Modules;
using ConsoleManager.Interface;
using ProgramManager.Interface;

namespace SupermarketCheckout
{
    /// <summary>
    /// <see cref="Ninject"/> Dependency Resolver based on http://www.ninject.org/
    /// </summary>
    /// <seealso cref="Ninject.Modules.NinjectModule" />
    public class NinjectDependencyResolver : NinjectModule
    {
        public override void Load()
        {
            Bind<IConsoleManager>().To<ConsoleManager.ConsoleManager>();
            Bind<IProgramManager>().To<ProgramManager.ProgramManager>();
        }
    }
}