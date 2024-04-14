namespace E_Commerce_Web_Application.Models
{
    public class Product
    {
        public string Title { get; set; }=string.Empty;
        public string Description { get; set; } = string.Empty;
        public int ProductId { get; set; }
        public List<string> ImageLink { get; set; } = new List<string>();
        public float Price {  get; set; }
        public int PercentageOff { get; set; }
        public float PriceAfterOff { get; set; }
        public float Rating {  get; set; }
        public string NoofRatings { get; set; }=string.Empty;
    }
}
