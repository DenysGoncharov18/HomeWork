using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppBLL.DTO
{
    class CategoryDateDTO
    {
        public Guid Id { set; get; }
        public DateTime StartDate { set; get; }
        public DateTime EndDate { set; get; }
        public decimal Price { set; get; }
        public virtual ICollection<CategoryDTO> Categories { get; set; }
        public CategoryDateDTO()
        {
            Id = Guid.NewGuid();
        }
    }
}
