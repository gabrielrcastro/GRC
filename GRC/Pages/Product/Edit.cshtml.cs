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
    public class EditModel : PageModel
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public EditModel(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        [BindProperty]
        public ProductViewModel Product { get; set; }
        public IEnumerable<CategoryViewModel> Categories { get; set; }

        public void OnGet(int? id)
        {
            try
            {
                if (!id.HasValue)
                {
                    TempData["MessageError"] = "Produto não encontrado";
                    RedirectToPage("Index");
                }

                Categories = _categoryService.GetAll();
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

        public ActionResult OnPost()
        {
            try
            {
                _productService.Update(Product);

                TempData["MessageSuccess"] = "Produto atualizado com sucesso";
                return RedirectToPage("Index");
            }
            catch (Exception ex)
            {
                TempData["MessageError"] = ex.Message;
                return RedirectToPage("Index");
            }
        }
    }
}