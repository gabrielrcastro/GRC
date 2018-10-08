using AutoMapper;
using GRC.Application.Models;
using GRC.Application.Services;
using GRC.Application.Services.Interfaces;
using GRC.Data.Context;
using GRC.Domain.Interfaces;
using GRC.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace GRC.Test
{
    [TestClass]
    public class CategoryTest
    {
        private Mock<ICategoryRepository> _mockCategoryRepository;
        private Mock<IMapper> _mockMapper;

        //public CategoryTest(ICategoryService categoryService, IMapper mapper)
        //{
        //    _categoryService = categoryService;
        //    _mapper = mapper;
        //}
        [TestInitialize]
        public void SetUp()
        {
            _mockCategoryRepository = new Mock<ICategoryRepository>();
            _mockMapper = new Mock<IMapper>();
        }

        [TestMethod]
        public void CategorySaveOk()
        {
            var category = new CategoryViewModel
            {
                Name = "Categoria Teste"
            };

            var mockSet = new Mock<DbSet<Category>>();

            var sut = new CategoryService(_mockMapper.Object, _mockCategoryRepository.Object);

            var mockContext = new Mock<FakeContext>();
            mockContext.Setup(m => m.Categories).Returns(mockSet.Object);

            sut.Register(_mockMapper.Object.Map<CategoryViewModel>(mockContext.Object));

            mockSet.Verify(m => m.Add(_mockMapper.Object.Map<Category>(category)), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }

        [TestMethod]
        public void CategorySaveError()
        {

        }

        [TestMethod]
        public void CategorySaveValidateOk()
        {

        }

        [TestMethod]
        public void CategorySaveValidateError()
        {

        }
    }
}
