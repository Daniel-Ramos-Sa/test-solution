namespace API_Teste.API_Teste.Domain
{
    /// <summary>
    /// InterfaceRepository
    /// </summary>
    public interface IAnimeRepository
    {
        Task<IEnumerable<Anime>> GetAllAsync();
        Task<IEnumerable<Anime>> GetFilteredAsync(string diretor, string nome, string palavrasChaves);
        Task<IEnumerable<Anime>> GetPagedAsync(int pageNumber, int pageSize);
        Task<Anime> GetByIdAsync(int id);
        Task<int> CreateAsync(Anime anime);
        Task UpdateAsync(Anime anime);
        Task SoftDeleteAsync(int id);
    }

}
