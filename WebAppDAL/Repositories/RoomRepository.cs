using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppDAL.EF;
using WebAppDAL.Entities;

namespace WebAppDAL.Repositories
{
    class RoomRepository: Repository<Room>
    {
        public RoomRepository(HotelContext context)
             : base(context, context.Rooms)
        {
            this.db = context;
            this.dbSet = context.Rooms;
        }
    }
}
