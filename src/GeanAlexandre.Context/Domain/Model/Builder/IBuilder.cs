using System;

namespace GeanAlexandre.Context.Domain.Model.Builder
{
    public interface IBuilder<out TEntity>
    {
        void ThenBuild(Action<TEntity> action);
    }
}