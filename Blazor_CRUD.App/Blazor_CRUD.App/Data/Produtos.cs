using Blazor_CRUD.App.Data;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorCRUD.App.Data
{
    public class Produtos
    {

        //[StringLength(100, ErrorMessage = "O Nome não pode ter mais que 100 caracteres.")]

        public int Id { get; set; }

        [MaxLength(20)]
        public string? Cod_Barras { get; set; }

        [MaxLength(100)]
        public string Descricao { get; set; } = string.Empty;

        [ForeignKey("Categoria_Id_PK")]
        public int Id_categoria { get; set; }

        [MaxLength(10)]
        public string? Un_Medida { get; set; }

        public int Quantidade { get; set; }

        [ForeignKey("Fornecedor_Id_PK")]
        public int Id_fornecedor { get; set; }

        [Column(TypeName = "decimal(10,0)")]
        public Decimal? Peso_Medio { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal? Peso_bruto { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal? Valor_Compra { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal? Margem_Lucro { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Valor_Venda { get; set; }

        public int? estoque_min { get; set; }

        public int? estoque_max { get; set; }

        public Byte[]? Foto { get; set; }

        public Categoria? categoria { get; set; }
        public Fornecedor? fornecedor { get; set; }
    }
}
