using AppNetRazor.Cursos;
using AppNetRazor.Datos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AppNetRazor.Pages.Cursos
{
    public class CrearModel : PageModel
    {
        //VA LA FUNCIONALIDAD EN C#, con esto ya puedo usar razor en html
        private readonly ApplicationDbContext _contexto;
        public CrearModel(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }
        //propiedad de vinculacion 
        [BindProperty]
        public Curso Curso { get; set; }   //vincula al formulario

        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid) { return Page(); }
            Curso.FechaCreacion = DateTime.Now;
            _contexto.Add(Curso);
            await _contexto.SaveChangesAsync();
            return RedirectToPage("Index");
        }
        

    }
}
