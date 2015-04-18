﻿using BrowseDotNet.Data.Infrastructure;
using BrowseDotNet.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowseDotNet.Data.Repositories
{
    public class ProgrammingLanguageRepository : RepositoryBase<ProgrammingLanguage>, IProgrammingLanguageRepository
    {
        public ProgrammingLanguageRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IProgrammingLanguageRepository : IRepository<ProgrammingLanguage>
    {

    }
}
