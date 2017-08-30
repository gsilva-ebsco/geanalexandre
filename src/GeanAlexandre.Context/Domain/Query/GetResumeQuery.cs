namespace GeanAlexandre.Context.Domain.Query
{
    public class GetResumeQuery : IQuery
    {
        public GetResumeQuery(string userName)
        {
            UserName = userName;
        }

        public string UserName { get; }

        public static GetResumeQuery CreateCommand(string userName)
        {
            return new GetResumeQuery(userName);
        }
    }
}