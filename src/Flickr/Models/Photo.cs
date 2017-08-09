using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flickr.Models
{
    [Table("Photos")]
    public class Photo
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }
        public byte[] Image { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        public Photo()
        {

        }
        public Photo(string title, string description, byte[] image)
        {
            Title = title;
            Description = description;
            Image = image;
        }
    }
}