namespace API_Teste.API_Teste.Domain
{
    public class UserDto
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }

        // Adicione outras propriedades conforme necessário para a transferência de dados

        public UserDto()
        {
            // Pode ser necessário um construtor vazio para serialização/desserialização
        }

        public UserDto(string id, string userName, string email)
        {
            Id = id;
            UserName = userName;
            Email = email;
            // Inicialize outras propriedades conforme necessário
        }
    }
}
