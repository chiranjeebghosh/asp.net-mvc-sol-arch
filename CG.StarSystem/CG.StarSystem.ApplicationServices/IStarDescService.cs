﻿using CG.StarSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CG.StarSystem.ApplicationServices
{
    public interface IStarDescService : IDisposable
    {
        Task<List<StarDesc>> GetAllStarsAsync();
        Task<StarDesc> GetStarDescriptionByIdAsync(int? id);
        Task AddStarAsync(StarDesc stardesc);
        Task DeleteStarAsync(int? id);
        Task EditStarDescAsync(StarDesc stardesc);

    }
}