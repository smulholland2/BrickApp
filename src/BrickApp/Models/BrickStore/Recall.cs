namespace BrickApp.Models.BrickStore
{
    public class Recall
    {
        public int RecallId { get; set; }
        public string Details { get; set; }

        public string ProductSKU { get; set; }
        public Product Product { get; set; }
    }
}
