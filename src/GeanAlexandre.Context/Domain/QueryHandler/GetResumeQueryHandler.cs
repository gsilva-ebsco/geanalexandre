using GeanAlexandre.Context.Domain.Model;
using GeanAlexandre.Context.Domain.Query;

namespace GeanAlexandre.Context.Domain.QueryHandler
{
    public class GetResumeQueryHandler : IQueryHandler<GetResumeQuery, Resume>
    {
        public Resume Execute(GetResumeQuery command)
        {
            return null;
        }
    }
}