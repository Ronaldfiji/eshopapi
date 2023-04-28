

namespace SharedModel.Models.eShopModels
{
    public class ProductImageDto
    {
        public int ID { get; set; }
        public string Path { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

    }

    public class ProductImagesToAddDto
    {
        public string base64data { get; set; } = string.Empty;
        public string contentType { get; set; } = string.Empty;
        public string fileName { get; set; } = string.Empty;

    }
}
