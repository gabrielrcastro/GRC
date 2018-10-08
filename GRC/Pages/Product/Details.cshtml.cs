using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GRC.Application.Models;
using GRC.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GRC.Application.Pages.Product
{
    public class DetailsModel : PageModel
    {
        private readonly IProductService _productService;

        public DetailsModel(IProductService productService)
        {
            _productService = productService;
        }

        [BindProperty]
        public ProductViewModel Product { get; set; }

        public void OnGet(int? id)
        {
            try
            {
                if (!id.HasValue)
                {
                    TempData["MessageError"] = "Produto não encontrado";
                    RedirectToPage("Index");
                }

                Product = _productService.GetById(id.Value);

                if (Product == null)
                {
                    TempData["MessageError"] = "Produto não encontrado";
                    RedirectToPage("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["MessageError"] = ex.Message;
                RedirectToPage("Index");
            }
        }
    }
}