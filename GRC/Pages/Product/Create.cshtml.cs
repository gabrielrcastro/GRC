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
    public class CreateModel : PageModel
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public CreateModel(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        [BindProperty]
        public ProductViewModel Product { get; set; }

        public IEnumerable<CategoryViewModel> Categories { get; set; }

        public void OnGet()
        {
            Categories = _categoryService.GetAll();
        }

        public ActionResult OnPost()
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return Page();
                }

                _productService.Register(Product);

                TempData["MessageSuccess"] = "Produto cadastrado com sucesso!";
                return RedirectToPage("Index");
            }
            catch (Exception ex)
            {
                TempData["MessageError"] = ex.Message;
                return Page();
            }
        }

    }
}