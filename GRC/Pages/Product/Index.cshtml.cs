using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GRC.Application.Models;
using GRC.Application.Services.Interfaces;

namespace GRC.Application.Pages.Product
{
    public class IndexModel : PageModel
    {
        private readonly IProductService _productService;

        public IndexModel(IProductService productService)
        {
            _productService = productService;
        }

        [BindProperty]
        public IEnumerable<ProductViewModel> Products { get; set; }

        public void OnGet()
        {
            try
            {
                Products = _productService.GetAll();
            }
            catch (Exception ex)
            {
                TempData["MessageError"] = ex.Message;
            }
        }
    }
}