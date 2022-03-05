using System.ComponentModel.DataAnnotations;//para el key 

namespace AppNetRazor.Cursos
 
{
    public class Curso
    {
        [Key]
        public  int id  { get; set; }
        [Required]
        [Display(Name ="Nombre de Curso")]
        public string NombreCurso { get; set; }
        [Display(Name = "Cantidad de clases")]
        public int CantidadClases { get; set; }
        public int Precio { get; set; }
        [Display(Name = "Fecha creacion")]
        public DateTime FechaCreacion { get; set; }
         

    }
}
