using API_Teste.API_Teste.Domain;

namespace API_Teste.API_Teste.Application
{
    /// <summary>
    /// Interface de Serviços
    /// </summary>
    public interface IAnimeService
    {
        Task<IEnumerable<Anime>> GetAllAnimesAsync();
        Task<IEnumerable<Anime>> GetFilteredAnimesAsync(string diretor, string nome, string palavrasChaves);
        Task<IEnumerable<Anime>> GetPagedAnimesAsync(int pageNumber, int pageSize);
        Task<Anime> GetAnimeByIdAsync(int id);
        Task<int> CreateAnimeAsync(Anime anime);
        Task UpdateAnimeAsync(Anime anime);
        Task SoftDeleteAnimeAsync(int id);
    }

}
