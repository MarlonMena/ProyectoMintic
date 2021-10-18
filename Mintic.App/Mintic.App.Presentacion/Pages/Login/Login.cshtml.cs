using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Mintic.App.Presentacion
{
    public class LoginModel : PageModel
    {
        private  Mintic.App.Persistencia.AppRepositories.Conexion conexion;


        [BindProperty]
        public string Usuario {get;set;}

        [BindProperty]
        public string Password {get;set;}

        [BindProperty]
        public string MensajeUsuario {get;set;}

        public string MensajePassword {get;set;}

        public void OnGet()
        {
        
        }
        public IActionResult OnPost()
        {
            conexion = new App.Persistencia.AppRepositories.Conexion();
            var p = conexion.Personas.Include(p => p.RolPersona).FirstOrDefault(p => p.Usuario == Usuario);
            if (p == null){
                MensajeUsuario = "Usuario no encontrado. Intenta de nuevo";
            }
            else if (!p.Password.Equals(Password)){
                HttpContext.Session.SetString("Usuario", Usuario);
                MensajePassword = "Contraseña incorrecta. Intenta de nuevo";
            }
            else if(p.Password.Equals(Password) && p.PrimerRegistro){
                HttpContext.Session.SetString("Usuario", Usuario);
                return RedirectToPage("./CambiarPassword");                
            }
            else{
                HttpContext.Session.SetString("UsuarioAutenticado", p.RolPersona.NombreRol);
                return RedirectToPage("../Index");
            }
            return Page();
        }
    }
}
