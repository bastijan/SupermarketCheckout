using ProgramManager.Interface;

namespace ProgramManager
{
    /// <summary>
    /// Abstract class implementing IProgramManager and providing any common implementations between all ProgramManagers
    /// </summary>
    /// <seealso cref="ProgramManager.IProgramManager" />
    public abstract class ProgramManagerBase : IProgramManager
    {
        public abstract void Run();
    }
}