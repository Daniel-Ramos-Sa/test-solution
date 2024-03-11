using API_Teste.API_Teste.Domain;

namespace API_Teste.API_Teste.Application
{
    public class AnimeService : IAnimeService
    {
        private readonly IAnimeRepository _animeRepository;

        public AnimeService(IAnimeRepository animeRepository)
        {
            _animeRepository = animeRepository;
        }

        public Task<int> CreateAnimeAsync(Anime anime)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Anime>> GetAllAnimesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Anime> GetAnimeByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Anime>> GetFilteredAnimesAsync(string diretor, string nome, string palavrasChaves)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Anime>> GetPagedAnimesAsync(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteAnimeAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAnimeAsync(Anime anime)
        {
            throw new NotImplementedException();
        }

        // Implemente os métodos da interface usando o repositório
    }

}
