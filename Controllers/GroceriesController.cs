using GroceriesListApi.Helpers;
using GroceriesListApi.Models.Dtos;
using GroceriesListApi.Models.Entities;
using GroceriesListApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GroceriesListApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroceriesController : Controller
    {
        private readonly IGroceriesListService _groceriesList;
        public GroceriesController(IGroceriesListService groceriesList)
        {
            _groceriesList = groceriesList;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {

            var list = await _groceriesList.GetAll();
            return Ok(list);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById(int id)
        {

            var list = await _groceriesList.GetById(id);
            if (list == null)
            {
                return NotFound();
            }
            return Ok(list);
        }

        // POST: api/Employee
        [HttpPost]
        public async Task<IActionResult> Post(GroceriesListDto createlist)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var operationResult = await _groceriesList.Save(createlist);

            if (operationResult.Status == OperationResultStatus.Success)
            {
                return Ok(operationResult.Data);
            }

            return BadRequest(operationResult.Message);
        }

        // PUT: api/Employee/5
        [HttpPut("{Id}")]
        public async Task<IActionResult> Put(int id, GroceriesListDto updateList)
        {
            if (id != updateList.Id)
            {
                return BadRequest();
            }

            var updatedList = await _groceriesList.Update(id, updateList);
            if (updatedList == null)
            {
                return NotFound();
            }

            return Ok(updatedList);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(int id)
        {

            var list = await _groceriesList.Delete(id);
            if (list == null)
            {
                return NotFound();
            }
            return Ok(list);
        }
    }
}
