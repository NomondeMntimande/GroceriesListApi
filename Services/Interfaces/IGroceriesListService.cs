using GroceriesListApi.Helpers;
using GroceriesListApi.Models.Dtos;
using GroceriesListApi.Models.Entities;

namespace GroceriesListApi.Services.Interfaces
{
    public interface IGroceriesListService
    {
        
        Task<OperationResult<GroceriesList>> GetById(int id);
        Task<OperationResult<List<GroceriesList>>> GetAll();
        Task<OperationResult<GroceriesList>> Save(GroceriesListDto groceriesList);
        Task<OperationResult<GroceriesList>> Update(int id, GroceriesListDto groceriesList);
        Task<OperationResult<bool>> Delete(int id);
    }
}
