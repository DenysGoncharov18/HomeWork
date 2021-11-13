using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace WebAppDAL.Entities
{
     public class Category
    {
        [Key]
        [Required]
        public Guid Id { set; get; }
        [Required]
        public string Name { set; get; }
        public int Bed { set; get; }
        public virtual ICollection<CategoryDate> CategoryDates { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
        public Category()
        {
            Id = Guid.NewGuid();
        }
    }
}
