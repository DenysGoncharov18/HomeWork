using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppDAL.EF;
using WebAppDAL.Entities;


namespace WebAppDAL.Repositories
{
    class АccommodationRepository:Repository<Аccommodation>
    {
        public АccommodationRepository(HotelContext context)
            : base(context, context.Аccommodations)
        {
            this.db = context;
            this.dbSet = context.Аccommodations;
        }
    }
}
