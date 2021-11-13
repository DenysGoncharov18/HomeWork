using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppBLL.DTO
{
    class АccommodationDTO
    {
        public Guid Id { set; get; }
        public Guid GuestId { set; get; }
        public Guid RoomId { set; get; }
        public DateTime StartDate { set; get; }
        public DateTime EndDate { set; get; }
        public bool? CheckedIn { set; get; }
        public bool? CheckedOut { set; get; }
        public virtual ICollection<RoomDTO> Rooms { get; set; }
        public virtual ICollection<GuestDTO> Guests { get; set; }
        public АccommodationDTO()
        {
            Id = Guid.NewGuid();
        }
    }
}
