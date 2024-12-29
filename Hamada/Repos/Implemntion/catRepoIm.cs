using Hamada.Models.appContext;
using Hamada.Models.Entity;
using Hamada.Repos.IRepo;
using Microsoft.EntityFrameworkCore;

namespace Hamada.Repos.Implemntion
{
    public class catRepoIm : Catgo
    {
        protected readonly AppDBContext db;
        public catRepoIm(AppDBContext db)
        {
            this.db = db;
        }
        public async Task<IEnumerable<Catgories>> GetCatgoAsync()
        {
            return await db.catgories.ToListAsync();
        }
    }
}
