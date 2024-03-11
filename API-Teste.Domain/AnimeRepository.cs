using API_Teste.API_Teste.Infrastructure;

namespace API_Teste.API_Teste.Domain
{
    public class AnimeRepository : IAnimeRepository
    {
        private readonly ApplicationDbContext _context;

        public AnimeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<int> CreateAsync(Anime anime)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Anime>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Anime> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Anime>> GetFilteredAsync(string diretor, string nome, string palavrasChaves)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Anime>> GetPagedAsync(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Anime anime)
        {
            throw new NotImplementedException();
        }

        // Implemente os métodos da interface
    }

}
