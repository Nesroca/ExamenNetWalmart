using Dapper.Contrib.Extensions;

namespace ExamenNet.DTO
{
    [Table("users")]
    public class UserDTO
    {
        [Key]
        public int id { get; set; }
        public string user_name { get; set; }
        public string pwd { get; set; }
    }
}
