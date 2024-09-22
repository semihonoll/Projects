using APIProject.Entities;
using APIProject.Repository.Abstract;
using APIProject.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIProject.Service.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepo _repo;

        public CategoryService(ICategoryRepo repo)
        {
            _repo = repo;
        }

        public async Task<List<Category>> GetAllAsync()
        {
            try
            {
                return await _repo.GetAllAsync();
            }
            catch
            {
                throw new Exception("Categoriler getirlemedi!");
            }
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            try
            {
                return await _repo.GetByIdAsync(id);
            }
            catch
            {
                throw new Exception("Kategori getirlemedi!");
            }
        }

        public Category Create(CreateCategoryDTO categoryDTO) 
        {
            var cat = new Category() { Name = categoryDTO.Name };
            return _repo.Create(cat);
        }

        public async Task<Category> Update(Category category, int id)
        {
            var cat = await _repo.GetByIdAsync(id);
            if (cat is null)
                throw new NullReferenceException("Categori nesnesi bulunamadı");

            cat.Id = category.Id != default ? category.Id : cat.Id;
            cat.Name = category.Name != default ? category.Name : cat.Name;
            return _repo.Update(cat);
        }
    }
}
