using ZenjectExtensions.Zinstallers;

namespace Commands.Core
{
    public abstract class CommandZinstaller : CachedInstanceZinstaller<ICommand>
    {
    }
}