using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppDAL.EF;
using WebAppDAL.Entities;

namespace WebAppDAL.Repositories
{
    class CategoryRepository:Repository<Category>
    {
        public CategoryRepository(HotelContext context)
            : base(context, context.Categories)
        {
            this.db = context;
            this.dbSet = context.Categories;
        }
    }
}
