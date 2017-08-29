using System;

namespace GeanAlexandre.Context.Domain.Model.Builder
{
    public class ResumeBuilder : IResumeBuilder
    {
        public ResumeLanguage Language { get; }

        private ResumeBuilder(ResumeLanguage language)
        {
            Language = language;
        }

        public static IResumeBuilder SetLanguage(ResumeLanguage language)
        {
            return new ResumeBuilder(language);
        }

        public void ThenBuild(Action<Resume> action)
        {
            action(new Resume(this));
        }
    }
}