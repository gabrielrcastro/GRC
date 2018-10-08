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
    public class IndexModel : PageModel
    {
        private readonly ICategoryService _categoryService;

        public IndexModel(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [BindProperty]
        public IEnumerable<CategoryViewModel> Categories { get; set; }

        public void OnGet()
        {
            try
            {
                Categories = _categoryService.GetAll();
            }
            catch (Exception ex)
            {
                TempData["MessageError"] = ex.Message;
            }
        }
    }
}