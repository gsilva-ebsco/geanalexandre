using GeanAlexandre.Context.Domain.Command;

namespace GeanAlexandre.Context.Domain.CommandHandler
{
    public interface ICommandHandler<in TCommand>
        where TCommand : ICommand
    {
        void Execute(TCommand command);
    }
}

