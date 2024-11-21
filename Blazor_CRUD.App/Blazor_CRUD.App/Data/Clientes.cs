using System.ComponentModel.DataAnnotations;

namespace BlazorCRUD.App.Data
{
    public class Clientes
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Nome { get; set; }
        public int Documento { get; set; }
    }
}
