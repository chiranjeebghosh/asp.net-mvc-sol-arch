using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CG.StarSystem.Data.Models;
using System.Data.Entity;

namespace CG.StarSystem.Repository.StarDescs
{
    public class StarDescRepository : IStarDescRepository, IDisposable
    {

        private StarSystemContext _context;

        /// <summary>
        ///     Create a new instance of <see cref="StarDescRepository" />.
        /// </summary>
        /// <param name="transaction">Active transaction</param>
        /// <exception cref="ArgumentNullException">transaction</exception>
        public StarDescRepository()
        {
            _context = new StarSystemContext();

        }

        
        public async Task<List<StarDesc>> GetStarDescsAsync()
        {
            return await _context.StarDescs.ToListAsync();
        }

        public async Task<StarDesc> GetStarDescByIdAsync(int? id)
        {
            return await _context.StarDescs.FindAsync(id);
        }

        public  async Task CreateStarAsync(StarDesc stardesc)
        {
             _context.StarDescs.Add(stardesc);
            await _context.SaveChangesAsync(); 
        }

        public async Task EditStarDescAsync(StarDesc stardesc)
        {
            _context.Entry(stardesc).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteStarAsync(int? id)
        {
            StarDesc stardesc = await _context.StarDescs.FindAsync(id);
            _context.StarDescs.Remove(stardesc);
            await _context.SaveChangesAsync();
        }
           
        
       

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                    _context.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~NoteRepository() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
            GC.SuppressFinalize(this);
        }


        #endregion
    }
}