using GeanAlexandre.Context.Domain.Command;
using GeanAlexandre.Context.Domain.CommandHandler;
using GeanAlexandre.Context.Domain.Model;

namespace GeanAlexandre.Context.Infra.Seed
{
    public class GeanAlexandreSeed
    {
        private readonly ICreateResumeCommandHandler _commandHandler;
        public static string Name => "geanalexandre";

        private GeanAlexandreSeed(ICreateResumeCommandHandler commandHandler)
        {
            _commandHandler = commandHandler;
        }

        private void Execute()
        {
            _commandHandler.ExecuteAsync(new CreateResumeCommand
            {
                UserName = "Gean Alexandre",
                Resume = new Resume
                {
                    ResumeLanguage = ResumeLanguage.En
                }
            });
        }

        public static void Seed(ICreateResumeCommandHandler createResumeCommandHandler) =>
            new GeanAlexandreSeed(createResumeCommandHandler).Execute();
    }
}