using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Mintic.App.Dominio;
using Mintic.App.Persistencia.AppRepositories;
using Microsoft.AspNetCore.Components;

namespace Mintic.App.Presentacion.Pages.CrudGrupo
{
    public class CreateModel : PageModel
    {
        private readonly Mintic.App.Persistencia.AppRepositories.Conexion _context;

        public SelectList ListaFormadores{get;set;}
        public SelectList ListaTutores{get;set;}
        
        [BindProperty]
        public int FormadorID {get; set;}

        [BindProperty]
        public int TutorID {get; set;}

        [BindProperty]
        public string Mensaje {get; set;}

        public CreateModel(Mintic.App.Persistencia.AppRepositories.Conexion context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            var ListaFormadoresBD = _context.Personas.Where(p => p.RolPersona.NombreRol =="Formador");
            var ListaTutoresBD = _context.Personas.Where(p => p.RolPersona.NombreRol =="Tutor");
            ListaFormadores = new SelectList(ListaFormadoresBD, nameof(Persona.Id),nameof(Persona.Nombres),nameof(Persona.Apellidos));
            ListaTutores = new SelectList(ListaTutoresBD, nameof(Persona.Id),nameof(Persona.Nombres),nameof(Persona.Apellidos));
            return Page();
        }

        [BindProperty]
        public Grupo Grupo { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Persona Formador = _context.Personas.FirstOrDefault(p => p.Id == FormadorID);
            Persona Tutor = _context.Personas.FirstOrDefault(p => p.Id == TutorID);
            var NumeroGrupos = _context.Grupos.Where(g => g.Formador == Formador).ToList();
            Grupo.Formador = Formador;
            Grupo.Tutor = Tutor;
            if(NumeroGrupos.Count() >=3){
                Mensaje = "El Formador alcanzo el maximo de grupos asignados";
                return this.OnGet();
            }else{
                _context.Grupos.Add(Grupo);
                await _context.SaveChangesAsync();

                return RedirectToPage("./Index");
            }

            
            
        }

       
    }
}
