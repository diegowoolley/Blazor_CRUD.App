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

        [StringLength(20, ErrorMessage ="O código de barras não pode ter mais de 13 carac")]
        public string? Cod_Barras { get; set; }

        [Required(ErrorMessage ="O campo descrição é obrigatório.")]
        [StringLength(100, ErrorMessage ="A descrição não pode conter mais de 100 carácteres.")]
        public string Descricao { get; set; } = string.Empty;

        [ForeignKey("Categoria_Id_PK")]
        public int Id_categoria { get; set; }

        [Required(ErrorMessage ="O campo unidade de medida é obrigatório.")]
        [MaxLength(10)]
        public string? Un_Medida { get; set; }

        [Required(ErrorMessage ="O campo quantidade é obrigatório")]
        [Range(1,99999999, ErrorMessage ="A quantidade não pode ser menor que 1.")]
        public int Quantidade { get; set; }

        [ForeignKey("Fornecedor_Id_PK")]
        public int Id_fornecedor { get; set; }

        [Column(TypeName = "decimal(10,0)")]
        public Decimal? Peso_Medio { get; set; } = decimal.Zero;

        [Column(TypeName = "decimal(10,2)")]
        public decimal? Peso_bruto { get; set; } = decimal.Zero;

        [Required(ErrorMessage ="O campo vl.compra é obrigatório.")]
        [Range(0.01, 99999999999, ErrorMessage = "O valor de compra não pode ser abaixo de 0.01.")]
        [Column(TypeName = "decimal(10,2)")]
        public decimal? Valor_Compra { get; set; } = decimal.Zero;

        [Column(TypeName = "decimal(10,2)")]
        public decimal? Margem_Lucro { get; set; } = decimal.Zero;

        [Required(ErrorMessage = "O campo vl.venda é obrigatório.")]
        [Range(0.01, 99999999999, ErrorMessage = "O valor de venda não pode ser abaixo de 0.01.")]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Valor_Venda { get; set; } = decimal.Zero;

        public int? estoque_min { get; set; } = 0;

        public int? estoque_max { get; set; } = 0;

        public Byte[]? Foto { get; set; }

        public Categoria? categoria { get; set; }
        public Fornecedor? fornecedor { get; set; }
    }
}
