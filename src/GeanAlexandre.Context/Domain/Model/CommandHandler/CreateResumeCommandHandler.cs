using System.Threading.Tasks;
using GeanAlexandre.Context.Domain.Command;
using GeanAlexandre.Context.Domain.Model.Builder;
using GeanAlexandre.Context.Domain.Uow;

namespace GeanAlexandre.Context.Domain.CommandHandler
{
    public class CreateResumeCommandHandler : ICreateResumeCommandHandler
    {
        private readonly IUow _uow;

        public CreateResumeCommandHandler(IUow uow)
        {
            _uow = uow;
        }

        public async Task ExecuteAsync(CreateResumeCommand command)
        {
             await UserBuilder
                .SetUserName(command.UserName)
                .ThenBuild(user => user.CreateNewResume(command.Resume))
                .ThenParse(_uow.AddAndSave);
        }
    }
}