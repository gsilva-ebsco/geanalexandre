using System.Threading.Tasks;
using GeanAlexandre.Context.Domain.Model;
using GeanAlexandre.Context.Domain.Query;
using GeanAlexandre.Context.Domain.Repository;

namespace GeanAlexandre.Context.Domain.QueryHandler
{
    public class GetResumeQueryHandler : IQueryHandler<GetResumeQuery, Resume>
    {
        private readonly IResumeRepository _resumeRepository;

        public GetResumeQueryHandler(IResumeRepository resumeRepository)
        {
            _resumeRepository = resumeRepository;
        }

        public Task<Resume> Execute(GetResumeQuery command)
        {
            return _resumeRepository.GetResumeByUserName(command?.UserName);
        }
    }
}