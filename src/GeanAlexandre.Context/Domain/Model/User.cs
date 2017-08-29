using System.Collections.Generic;
using GeanAlexandre.Context.Domain.Model.Builder;

namespace GeanAlexandre.Context.Domain.Model
{
    public class User
    {
        public string UserName { get; }
        public IDictionary<ResumeLanguage, Resume> Rusumes { get; private set; }

        public User(IUserBuilder builder)
        {
            UserName = builder.UserName;
        }
    }
}