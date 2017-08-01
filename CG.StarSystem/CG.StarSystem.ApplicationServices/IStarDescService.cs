using CG.StarSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CG.StarSystem.ApplicationServices
{
    public interface IStarDescService : IDisposable
    {
          Task<StarDesc> GetStarDescriptionById(int? id);
         Task<List<StarDesc>> GetAllStars();


    }
}