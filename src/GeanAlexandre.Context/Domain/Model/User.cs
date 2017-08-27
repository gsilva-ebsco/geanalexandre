using System;
using System.Collections.Generic;

namespace GeanAlexandre.Context.Domain.Model
{
    public class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public IEnumerable<Resume> Rusumes { get; set; }
    }
}