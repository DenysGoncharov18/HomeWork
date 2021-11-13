using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppDAL.Entities;

namespace WebAppDAL.Interfaces
{
    public interface IHotelUW : IDisposable
    {
        IRepository<Guest> Guests { get; }
        IRepository<Аccommodation> Аccommodations { get; }
        IRepository<Room> Rooms { get; }
        IRepository<Category> Categories { get; }
        IRepository<CategoryDate> CategoryDates { get; }
        void Save();
    }
}
