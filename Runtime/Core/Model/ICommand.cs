namespace Commands.Core
{
    public interface ICommand
    {
        void Execute();
    }

    public interface ICommand<ParamType>
    {
        void Execute(ParamType parameter);
    }
}