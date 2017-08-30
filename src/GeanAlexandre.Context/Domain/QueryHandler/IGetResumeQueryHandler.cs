using GeanAlexandre.Context.Domain.Model;
using GeanAlexandre.Context.Domain.Query;

namespace GeanAlexandre.Context.Domain.QueryHandler
{
    public interface IGetResumeQueryHandler : IQueryHandler<GetResumeQuery, Resume>
    {
    }
}