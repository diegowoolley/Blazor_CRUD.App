using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorCRUD.App.Data
{
    public class Produtos
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Descricao { get; set; }

        public int Quantidade { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Preco { get; set; }
    }
}
