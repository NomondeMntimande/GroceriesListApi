namespace GroceriesListApi.Models.Dtos
{
    public class ListItemDto
    {
        public int Id { get; set; }
        public string itemName { get; set; }
        public bool bought { get; set; }
        public int addedBy { get; set; }
    }
}
