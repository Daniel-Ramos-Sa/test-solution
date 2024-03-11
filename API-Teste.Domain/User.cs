using System.ComponentModel.DataAnnotations;

namespace API_Teste.API_Teste.Domain
{
    public class User
    {
        [Key]
        public string Id { get; set; }

        [Required]
        [MaxLength(256)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(256)]
        public string Email { get; set; }

       
    }
}
