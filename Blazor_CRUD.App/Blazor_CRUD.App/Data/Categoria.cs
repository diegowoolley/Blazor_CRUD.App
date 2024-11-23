using BlazorCRUD.App.Data;
using System.ComponentModel.DataAnnotations;

namespace Blazor_CRUD.App.Data
{
    public class Categoria
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Nome { get; set; } = string.Empty;

        //public ICollection<Produtos> produtos { get; set; } = new List<Produtos>();
    }
}
