using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppDAL.EF;
using WebAppDAL.Entities;

namespace WebAppDAL.Repositories
{
    class CategoryDateRepository:Repository<CategoryDate>
    {
        public CategoryDateRepository(HotelContext context)
            :base(context, context.CategoryDates)
        {
            this.db = context;
            this.dbSet = context.CategoryDates;
        }

    }
}
