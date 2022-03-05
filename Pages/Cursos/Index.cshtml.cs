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
        public async Task OnGet()
        {
            Cursos = await _contexto.Curso.ToListAsync();
        }
    }
}
