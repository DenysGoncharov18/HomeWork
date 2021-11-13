using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppBLL.DTO
{
    class CategoryDTO
    {
        
        public Guid Id { set; get; }
        public string Name { set; get; }
        public int Bed { set; get; }
        public virtual ICollection<CategoryDateDTO> CategoryDates { get; set; }
        public virtual ICollection<RoomDTO> Rooms { get; set; }
        public CategoryDTO()
        {
            Id = Guid.NewGuid();
        }
    }
}
