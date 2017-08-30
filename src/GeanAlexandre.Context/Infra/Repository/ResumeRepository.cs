using System.Threading.Tasks;
using GeanAlexandre.Context.Domain.Model;
using GeanAlexandre.Context.Domain.Repository;
using MongoDB.Driver;
using IMongoDatabase = GeanAlexandre.Context.Infra.Database.IMongoDatabase;

namespace GeanAlexandre.Context.Infra.Repository
{
    public class ResumeRepository : IResumeRepository
    {
        private readonly IMongoDatabase _database;

        public ResumeRepository(IMongoDatabase database)
        {
            _database = database;
        }

        public Task<Resume> GetResumeByUserName(string userName)
        {
            var filter = Builders<Resume>.Filter.Eq("UserName", userName);
            return _database.GetCollection<Resume>().Find(filter).FirstAsync();
        }
    }
}