namespace ClothStoreApplication.ViewModels
{
    public class CartItemViewModel
    {
        public int ProductId { get; set; }

        public string ImageUrl { get; set; }

        public string ProductName { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }
    }
}
