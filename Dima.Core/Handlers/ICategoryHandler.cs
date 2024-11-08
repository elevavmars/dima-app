using Dima.Core.Models;
using Dima.Core.Requests.Categories;
using Dima.Core.Responses;

namespace Dima.Core.Handlers;

public interface ICategoryHandler
{
    Task<Response<Category>> CreateAsync(CreateCategoryRequest request);
    Task<Response<Category>> CreateAsync(UpdateCategoryRequest request);
    Task<Response<Category>> CreateAsync(DeleteCategoryRequest request);
    Task<Response<Category>> GetByIdAsync(GetCategoryByIdRequest request);
    Task<Response<List<Category>>> GetAllByIdAsync(GetAllCategoriesRequest request);
}