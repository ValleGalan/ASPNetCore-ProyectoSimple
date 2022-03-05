using AppNetRazor.Cursos;
using AppNetRazor.Datos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore; //  ToListAsync para que pueda recorrer

namespace AppNetRazor.Pages.Cursos
{
    public class IndexModel : PageModel
    {
        //VA LA FUNCIONALIDAD EN C#, con esto ya puedo usar razor en html
        private readonly ApplicationDbContext _contexto;
        public IndexModel(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }
        //
        public IEnumerable<Curso> Cursos { get; set; }
        [TempData]
        public string Mensaje { get; set; } //para la notificacion
        public async Task OnGet()
        {
            Cursos = await _contexto.Curso.ToListAsync();
        }


        //BORRAR
        public async Task<IActionResult> OnPostBorrar( int id)
        {
           
                var curso = await _contexto.Curso.FindAsync(id);
                if(curso== null)
                {
                    return NotFound();
                }
 
                _contexto.Curso.Remove(curso);
                await _contexto.SaveChangesAsync();
                Mensaje = "Curso borrado correctamente";
            return RedirectToPage("Index");
            
        }
    }
}
