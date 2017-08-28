namespace GeanAlexandre.Context.Domain.Command
{
    public class CreateResumeCommand : ICommand
    {
        public string UserName { get; set; }
    }
}