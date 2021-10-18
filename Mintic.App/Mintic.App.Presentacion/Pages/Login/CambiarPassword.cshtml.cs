using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Mintic.App.Persistencia.AppRepositories;

namespace Mintic.App.Presentacion.Pages
{
   public class CambiarPasswordModel : PageModel
    {
        [BindProperty]
        public string Password {get;set;}

        [BindProperty]
        public string RepeatPassword {get;set;}

        [BindProperty]
        public string Mensaje {get;set;}
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            Conexion conexion = new Conexion();
            var Usuario = HttpContext.Session.GetString("Usuario");
            var p = conexion.Personas.FirstOrDefault(p => p.Usuario == Usuario);
            
            if(Password.Equals(RepeatPassword)){
                Mensaje = "Contraseña modificada exitosamente";
                p.Password = Password;
                p.PrimerRegistro = false;
                conexion.SaveChanges();
                return RedirectToPage("../Index");
            }
            else{
                Mensaje = "Las contraseñas no coinciden";
                return Page();
            }
        }
    }
}
