using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using WebAppBLL.DTO;
using WebAppDAL.Entities;
using WebAppDAL.Interfaces;

namespace WebAppBLL.Services
{
    class AccommodationService
    {
        IHotelUW db;
        public AccommodationService(IHotelUW db)
        {
            this.db = db;
        }

        public АccommodationDTO CreateAccommodationDTO(Guid id)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Аccommodation, АccommodationDTO>()).CreateMapper();

            return mapper.Map<Аccommodation, АccommodationDTO>(db.Аccommodations.Get(id));
        }
        public IEnumerable<АccommodationDTO> GetАccommodationDTO()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Аccommodation, АccommodationDTO>()).CreateMapper();

            return mapper.Map<IEnumerable<Аccommodation>, List<АccommodationDTO>>(db.Аccommodations.GetAll());
        }

        public void UpdateАccommodationDTO(АccommodationDTO accommodation)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Guest, GuestDTO>()).CreateMapper();

            return mapper.Map<АccommodationDTO, Аccommodation>(db.Guests.Update(accommodation));
        }

        public void DeleteGuestDTO(Guid id)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Аccommodation, АccommodationDTO>()).CreateMapper();

            return mapper.Map<Аccommodation, АccommodationDTO>(db.Аccommodations.Delete(id));
        }
    }
}
