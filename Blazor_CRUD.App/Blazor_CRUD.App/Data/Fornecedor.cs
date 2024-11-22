using BlazorCRUD.App.Data;
using System.ComponentModel.DataAnnotations;

namespace Blazor_CRUD.App.Data
{
    public class Fornecedor
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Nome { get; set; } = string.Empty;

        [MaxLength(20)]
        public string Documento { get; set; } = string.Empty;

        [MaxLength(100)]
        public string? email { get; set; }

        [MaxLength(10)]
        public string? cep { get; set; }

        [MaxLength(100)]
        public string? endereco { get; set; }

        [MaxLength(100)]
        public string? bairro { get; set; }

        public int? numero { get; set; }

        [MaxLength(100)]
        public string? cidade { get; set; }

        [MaxLength(10)]
        public string? uf { get; set; }

        [MaxLength(20)]
        public string? telefone { get; set; }

        [MaxLength(20)]
        public string? celular { get; set; }

        public Byte[]? Foto { get; set; }

        public ICollection<Produtos> produtos { get; set; } = new List<Produtos>();


    }
}
