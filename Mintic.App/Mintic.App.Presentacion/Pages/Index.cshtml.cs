using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;

namespace Mintic.App.Presentacion.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnGet()
        {
            if(HttpContext.Session.GetString("UsuarioAutenticado")!=null){
                return RedirectToPage("/CrudPersona/Index");
            }
            else{
                return RedirectToPage("Login/Login");
            }
            

        }
    }
}
