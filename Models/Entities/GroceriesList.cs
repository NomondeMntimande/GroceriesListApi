namespace GroceriesListApi.Models.Entities
{
    public class GroceriesList
    {
        public int Id { get; set; }
        public string listName { get; set; }
        public string listOwner { get; set; }
        public int categoryListId { get; set; }
        public string categoryName { get; set; }
        public int listItemId { get; set; }
        public string itemName { get; set; }
    }
}
