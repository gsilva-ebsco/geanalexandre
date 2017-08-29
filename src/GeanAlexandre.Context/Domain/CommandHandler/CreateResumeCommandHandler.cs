using System.Threading.Tasks;
using GeanAlexandre.Context.Domain.Command;
using GeanAlexandre.Context.Domain.Model.Builder;
using GeanAlexandre.Context.Domain.Uow;

namespace GeanAlexandre.Context.Domain.CommandHandler
{
    public class CreateResumeCommandHandler : ICommandHandler<CreateResumeCommand>
    {
        private readonly IUow _uow;

        public CreateResumeCommandHandler(IUow uow)
        {
            _uow = uow;
        }

        public Task Execute(CreateResumeCommand command)
        {
            UserBuilder
                .SetUserName(command.UserName)
                .ThenBuild(user => _uow.AddAndSave(user).Wait());

            return Task.CompletedTask;
        }
    }
}