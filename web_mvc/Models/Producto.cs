using System.ComponentModel.DataAnnotations;
namespace web_mvc.Models
{
    public class Producto
    {
        [Display(Name = "Id")] public int Id { get; set; }
        [Display(Name = "Fecha_Creacion")] public string Fecha_Creacion { get; set; }
        [Display(Name = "idact")] public int idact { get; set; }
        [Display(Name = "Nombre")] public string Nombre { get; set; }
        [Display(Name = "Precio")] public string Precio { get; set; }
        [Display(Name = "desact")] public string desact { get; set; }


    }
}
