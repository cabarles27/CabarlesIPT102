namespace CabarlesFramework.Models
{
    public class POS_Models
    {

        public int Id { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string Price { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public string TotalAmount { get; set; } = string.Empty;
    }
}

