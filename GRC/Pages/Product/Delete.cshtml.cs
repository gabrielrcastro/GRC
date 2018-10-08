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
    public class DeleteModel : PageModel
    {
        private readonly IProductService _productService;

        public DeleteModel(IProductService productService)
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
            }
            catch (Exception ex)
            {
                RedirectToPage("Index");
                TempData["MessageError"] = ex.Message;
            }
        }

        public ActionResult OnPost()
        {
            try
            {
                _productService.Remove(Product.Id);

                TempData["MessageSuccess"] = "Produto excluído com sucesso";
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