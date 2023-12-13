using GroceriesListApi.Models.Entities;

namespace GroceriesListApi.Models.Dtos
{
    public class GroceriesListDto
    {
        public int Id { get; set; }
        public string listName { get; set; }
        public string listOwner { get; set; }
        
        public int categoryListId { get; set; }
        public string listItemId { get; set; }
    }
}
