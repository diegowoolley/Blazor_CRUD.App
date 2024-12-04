using System.ComponentModel.DataAnnotations;

namespace BlazorCRUD.App.Data
{
    public class Clientes
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 100 caracteres.")]
        public string Nome { get; set; } = string.Empty;


        [Required(ErrorMessage = "O documento é obrigatório.")]
        [RegularExpression(@"^\d{11}$|^\d{14}$",
               ErrorMessage = "Insira um CPF (11 dígitos) ou CNPJ (14 dígitos) válido.")]
        public string Documento { get; set; } = string.Empty;


        [Required(ErrorMessage = "O e-mail é obrigatório.")]
        [EmailAddress(ErrorMessage = "Formato de e-mail inválido.")]
        public string? email { get; set; }

        [MaxLength(10, ErrorMessage = "O CEP não pode ter mais de 10 caracteres.")]
        [RegularExpression(@"^\d{5}-?\d{3}$", ErrorMessage = "Formato de CEP inválido. Use o formato 12345-678.")]
        public string? cep { get; set; }

        [MaxLength(100)]
        public string? endereco { get; set; }

        [MaxLength(100)]
        public string? bairro { get; set; }

        public int? numero { get; set; } = 0;

        [MaxLength(100)]
        public string? cidade { get; set; }

        [MaxLength(10)]
        public string? uf { get; set; }

        [RegularExpression(@"^(\(?\d{2}\)?[\s-]?)?\d{4,5}[\s-]?\d{4}$", ErrorMessage = "Insira um número de telefone válido.")]
        public string? telefone { get; set; }

        [RegularExpression(@"^(\(?\d{2}\)?[\s-]?)?\d{4,5}[\s-]?\d{4}$", ErrorMessage = "Insira um número de celular válido.")]
        public string? celular { get; set; }

        public Byte[]? Foto { get; set; }


    }
}
