using System;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppDAL.Entities;
using WebAppDAL.EF;
using WebAppBLL.DTO;
using WebAppDAL.Interfaces;

namespace WebAppBLL.Services
{
    class GuestService
    {
        IHotelUW db;
        public GuestService(IHotelUW db)
        {
            this.db = db;
        }

        public GuestDTO CreateGuestDTO(Guid id)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Guest, GuestDTO>()).CreateMapper();

            return mapper.Map<Guest,GuestDTO>(db.Guests.Get(id));
        }
        public IEnumerable<GuestDTO> GetGuestsDTO()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Guest, GuestDTO>()).CreateMapper();
            
            return mapper.Map<IEnumerable<Guest>, List<GuestDTO>>(db.Guests.GetAll());
        }

        public void UpdateGuestDTO(GuestDTO guest)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Guest, GuestDTO>()).CreateMapper();

            return mapper.Map<GuestDTO, Guest>(db.Guests.Update(guest));
        }

        public void DeleteGuestDTO(Guid id)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Guest, GuestDTO>()).CreateMapper();

            return mapper.Map<Guest,GuestDTO>(db.Guests.Delete(id));
        }
    }
}
