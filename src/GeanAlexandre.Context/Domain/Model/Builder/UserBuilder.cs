using System;

namespace GeanAlexandre.Context.Domain.Model.Builder
{
    public class UserBuilder : IUserBuilder
    {
        public string UserName { get; }

        private UserBuilder(string userName)
        {
            UserName = userName;
        }

        public static IUserBuilder SetUserName(string userName)
        {
            return new UserBuilder(userName);
        }

        public void ThenBuild(Action<User> action)
        {
            action(new User(this));
        }
    }
}