using ZenjectExtensions.Zinstallers;

namespace Commands.Core
{
    public abstract class CommandTypeZinstaller<DataType> : CachedInstanceZinstaller<ICommand<DataType>>
    {
    }
}