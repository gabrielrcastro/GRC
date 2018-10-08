using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GRC.Application.Models;
using GRC.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GRC.Application.Pages.Category
{
    public class EditModel : PageModel
    {
        private readonly ICategoryService _categoryService;

        public EditModel(ICategoryService categoryService)
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

                if (Category == null)
                {
                    TempData["MessageError"] = "Categoria não encontrada";
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
                _categoryService.Update(Category);

                TempData["MessageSuccess"] = "Categoria atualizada com sucesso";
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