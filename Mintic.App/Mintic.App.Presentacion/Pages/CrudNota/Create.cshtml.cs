using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Mintic.App.Dominio;
using Mintic.App.Persistencia.AppRepositories;

namespace Mintic.App.Presentacion.Pages.CrudNota
{
    public class CreateModel : PageModel
    {
        private readonly Mintic.App.Persistencia.AppRepositories.Conexion _context;

        public CreateModel(Mintic.App.Persistencia.AppRepositories.Conexion context)
        {
            _context = context;
        }

        //public SelectList Alumnos;

        public IActionResult OnGet()
        {
            //var listadoAlumnos = _context.Estudiantes.ToList();

            //estudiantes = new SelectList(listadoAlumnos, 
                        //nameof(Estudiantes.Id), nameof(Estudiantes.Nombres), null, null);

            return Page();
        }

        [BindProperty]
        public Nota Nota { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Notas.Add(Nota);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
