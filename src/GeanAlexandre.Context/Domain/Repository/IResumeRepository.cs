using System.Threading.Tasks;
using GeanAlexandre.Context.Domain.Model;

namespace GeanAlexandre.Context.Domain.Repository
{
    public interface IResumeRepository
    {
        Task<Resume> GetResumeByUserName(string userName);
    }
}