using AutoMapper;
using GroceriesListApi.Data;
using GroceriesListApi.Helpers;
using GroceriesListApi.Models.Dtos;
using GroceriesListApi.Models.Entities;
using GroceriesListApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GroceriesListApi.Services
{
    public class GroceriesListService : IGroceriesListService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public GroceriesListService(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<OperationResult<bool>> Delete(int Id)
        {
            try
            {
                var list = await _dbContext.GroceriesList.FindAsync(Id);
                if (list == null)
                    return OperationResult<bool>.Failure("Groceries list not found.");

                _dbContext.GroceriesList.Remove(list);
                await _dbContext.SaveChangesAsync();

                return OperationResult<bool>.Success(true);
            }
            catch (Exception ex)
            {
                return OperationResult<bool>.Failure($"Error deleting Groceries list: {ex.Message}");
            }
        }

        public async Task<OperationResult<List<GroceriesList>>> GetAll()
        {
            try
            {
                var list = await _dbContext.GroceriesList.ToListAsync();
                return OperationResult<List<GroceriesList>>.Success(list);
            }
            catch (Exception ex)
            {
                return OperationResult<List<GroceriesList>>.Failure($"Error Groceries list: {ex.Message}");
            }
        }

        public async Task<OperationResult<GroceriesList>> GetById(int id)
        {
            try
            {
                var list = await _dbContext.GroceriesList.FirstOrDefaultAsync(e => e.Id == id);
                if (list == null)
                    return OperationResult<GroceriesList>.Failure("Groceries list not found.");

                return OperationResult< GroceriesList>.Success(list);
            }
            catch (Exception ex)
            {
                return OperationResult<GroceriesList>.Failure($"Error retrieving Groceries List: {ex.Message}");
            }
        }

        public async Task<OperationResult<GroceriesList>> Save(GroceriesListDto groceriesListDto)
        {
            try
            {
               

                var list = _mapper.Map<GroceriesList>(groceriesListDto);
                await _dbContext.GroceriesList.AddAsync(list);
                await _dbContext.SaveChangesAsync();
                return OperationResult<GroceriesList>.Success(list);
            }
            catch (Exception ex)
            {
                return OperationResult<GroceriesList>.Failure($"Error creating Groceries List: {ex.Message}");
            }
        }

        public async Task<OperationResult<GroceriesList>> Update(int id,GroceriesListDto groceriesListDto)
        {
            try
            {
                var existingList = await _dbContext.GroceriesList.FirstOrDefaultAsync(e => e.Id == id);
                if (existingList == null)
                    return OperationResult<GroceriesList>.Failure("Groceries List not found.");

                existingList.listName = groceriesListDto.listName;
                existingList.listOwner = groceriesListDto.listOwner;
                // Update other properties as needed

                await _dbContext.SaveChangesAsync();

                return OperationResult<GroceriesList>.Success(existingList);
            }
            catch (Exception ex)
            {
                return OperationResult<GroceriesList>.Failure($"Error updating Groceries List: {ex.Message}");
            }
        }



    }
}
