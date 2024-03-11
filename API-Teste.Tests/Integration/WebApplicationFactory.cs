using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;

namespace API_Teste.API_Teste.Tests.Integration
{
    public class CustomWebApplicationFactory<TStartup> : WebApplicationFactory<TStartup> where TStartup : class
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            // Configurações adicionais do servidor de teste
            // Isso pode incluir a configuração de banco de dados em memória, por exemplo.
        }
    }
}
