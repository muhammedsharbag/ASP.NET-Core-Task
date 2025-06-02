using System.IO;
using Microsoft.AspNetCore.Mvc;
using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;

namespace Shar01.Controllers
{
    public class MoviesController:Controller
    {
        public IActionResult GetMovie(int id)
        {
            //ContentResult result = new ContentResult();
            //result.Content = $"Movie ID : {id}";
            //result.ContentType = "text/html";
            //result.ContentType = "object/pdf";
            return Content($"Movie ID : {id}", "text/html");
        }

        public IActionResult Hamda()
        {
            RedirectResult result = new RedirectResult("https://web.vodafone.com.eg/en/vodafone-red1");
                return result;
        }





    }
    }


