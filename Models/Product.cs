namespace E_Commerce_Web_Application.Models
{
    public class Product
    {
        public string Title { get; set; }=string.Empty;
        public string Description { get; set; } = string.Empty;
        public int ProductId { get; set; }
        public string[] ImageLink { get; set; } = Array.Empty<string>();
    }
}
