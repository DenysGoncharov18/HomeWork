using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppDAL.EF;
using WebAppDAL.Entities;

namespace WebAppDAL.Repositories
{
    class GuestRepository:Repository<Guest>
    {
        public GuestRepository(HotelContext context)
             : base(context, context.Guests)
        {
            this.db = context;
            this.dbSet = context.Guests;
        }
    }
}
