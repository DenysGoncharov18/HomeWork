using Microsoft.EntityFrameworkCore;
using WebAppDAL.Entities;

using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppDAL.EF
{
    public class HotelContext: DbContext
    {
        public HotelContext(DbContextOptions<HotelContext> options)
           : base(options)
        {
            Database.EnsureCreated();
        }
        public virtual DbSet<Room> Rooms { set; get; }
        public virtual DbSet<Guest> Guests { set; get; }
        public virtual DbSet<Category> Categories { set; get; }
        public virtual DbSet<CategoryDate> CategoryDates { set; get; }
        public virtual DbSet<Аccommodation> Аccommodations { set; get; }
    }
}
