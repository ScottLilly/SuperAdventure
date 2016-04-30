namespace Engine
{
    public class LootItem
    {
        public Item Details { get; set; }
        public int DropPercentage { get; set; }
        public bool IsDefaultItem { get; set; }

        public LootItem(Item details, int dropPercentage, bool isDefaultItem)
        {
            Details = details;
            DropPercentage = dropPercentage;
            IsDefaultItem = isDefaultItem;
        }
    }
}
