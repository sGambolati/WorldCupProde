﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Southworks.Prode.Data.Models;

namespace Southworks.Prode.Services.Data
{
    public interface IMatchesService
    {
        IQueryable<MatchEntity> GetMatches();

        Task<MatchEntity> SaveMatch(MatchEntity entity);

        bool ExistsMatch(Guid homeTeam, Guid awayTeam, MatchStage stage);

        MatchEntity GetMatch(Guid id);
    }
}
