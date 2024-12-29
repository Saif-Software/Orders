using Hamada.Models.Entity;

namespace Hamada.Repos.IRepo
{
    public interface Catgo
    {
        public Task<IEnumerable<Catgories>> GetCatgoAsync();
    }
}
