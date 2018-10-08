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

namespace GRC.Application.Pages.Category
{
    public class DeleteModel : PageModel
    {
        private readonly ICategoryService _categoryService;

        public DeleteModel(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [BindProperty]
        public CategoryViewModel Category { get; set; }

        public void OnGet(int? id)
        {
            try
            {
                if (!id.HasValue)
                {
                    TempData["MessageError"] = "Categoria não encontrada";
                    RedirectToPage("Index");
                }

                Category = _categoryService.GetById(id.Value);
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
                _categoryService.Remove(Category.Id);

                TempData["MessageSuccess"] = "Categoria excluída com sucesso";
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