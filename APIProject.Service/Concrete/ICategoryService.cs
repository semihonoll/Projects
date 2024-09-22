using APIProject.Entities;
using APIProject.Service.DTOs;

namespace APIProject.Service.Concrete
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAllAsync();
        Task<Category> GetByIdAsync(int id);
        Category Create(CreateCategoryDTO categoryDTO);
        Task<Category> Update(Category category, int id);
    }
}