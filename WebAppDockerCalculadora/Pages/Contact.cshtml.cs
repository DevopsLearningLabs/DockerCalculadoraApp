using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebAppDockerCalculadora.Pages
{
    public class ContactModel : PageModel
    {
        private readonly ILogger<ContactModel> _logger;
        private readonly ICalculadora calculadora;

        public ContactModel(ILogger<ContactModel> logger, ICalculadora calculadora )
        {
            _logger = logger;
            this.calculadora = calculadora;
        }
        public void OnGet()
        {

            var result = calculadora.suma(5, 4);
            
        }

        public void OnPost()
        {
            var a = Convert.ToInt32( Request.Form["Labela"]);
            var b = Convert.ToInt32( Request.Form["Labelb"]);
            // do something with emailAddress
            var result = calculadora.suma(a, b);
            var result2 = calculadora.substrac(a, b);
            var result3 = calculadora.multiply(a, b);
            var result4 = calculadora.divide(a, b);


            ViewData["resultadoSuma"] =  $"suma entre {a} + {b} =  {result}";
            ViewData["resultadoResta"] =  $"Resta entre {a} - {b} =  {result2}";
            ViewData["resultadoMulti"] =  $"Multiplicacion entre {a} * {b} =  {result3}";
            ViewData["resultadoDivision"] =  $"Division entre {a} / {b} =  {result4}";

        }
    }
}
