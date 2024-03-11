using System.Runtime.CompilerServices;

namespace API_Teste.API_Teste.Domain
{
    /// <summary>
    /// Classe Anime - Contendo as Entidades.
    /// </summary>
    public class Anime
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Resumo { get; set; }
        public string Diretor { get; set; }
        // Outros campos, se necessário
    }

}
