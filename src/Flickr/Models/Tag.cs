using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flickr.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PhotoId { get; set; }
    }
}