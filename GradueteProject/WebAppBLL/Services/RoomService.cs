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
    class RoomService
    {
        IHotelUW db;
        public RoomService(IHotelUW db)
        {
            this.db = db;
        }

        public RoomDTO CreateRoomDTO(Guid id)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Room, RoomDTO>()).CreateMapper();

            return mapper.Map<Room, RoomDTO>(db.Rooms.Get(id));
        }
        public IEnumerable<RoomDTO> GetRoomsDTO()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Room, RoomDTO>()).CreateMapper();

            return mapper.Map<IEnumerable<Room>, List<RoomDTO>>(db.Rooms.GetAll());
        }

        public void UpdateRoomDTO(RoomDTO room)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Room, RoomDTO>()).CreateMapper();

            return mapper.Map<RoomDTO, Room>(db.Rooms.Update(room));
        }

        public void DeleteRoomDTO(Guid id)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Room, RoomDTO>()).CreateMapper();

            return mapper.Map<Room, RoomDTO>(db.Guests.Delete(id));
        }
    }
}
