using GeanAlexandre.Context.Domain.Query;

namespace GeanAlexandre.Context.Domain.QueryHandler
{
    public interface IQueryHandler<in TQuery, out TResult>
        where TQuery : IQuery
    {
        TResult Execute(TQuery command);
    }
}