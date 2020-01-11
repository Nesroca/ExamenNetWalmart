using Dapper.Contrib.Extensions;


namespace ExamenNet.DTO
{
    [Table("products")]
    public class ProductDTO
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string sku { get; set; }
        public string description { get; set; }
    }
}
