using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppDAL.EF;
using WebAppDAL.Entities;
using WebAppDAL.Interfaces;

namespace WebAppDAL.Repositories
{
    class HotelUW : IHotelUW
    {
        private HotelContext db;
        private RoomRepository roomRepository;
        private GuestRepository guestRepository;
        private АccommodationRepository аccommodationRepository;
        private CategoryRepository categoryRepository;
        private CategoryDateRepository categoryDateRepository;
        private bool disposed = false;
        public HotelUW(string connectionString)
        {
            db = new HotelContext(connectionString);
        }
        public IRepository<Room> Rooms
        {
            get 
            {
                if (roomRepository == null)
                {
                    roomRepository = new RoomRepository(db);
                }
                return roomRepository;
            }
        
        }
        public IRepository<Guest> Guests
        {
            get
            {
                if (guestRepository == null)
                {
                    guestRepository = new GuestRepository(db);
                }
                return guestRepository;
            }
        }
        public IRepository<Category> Categories
        {
            get
            {
                if (categoryRepository == null)
                {
                    categoryRepository = new CategoryRepository(db);
                }
                return categoryRepository;
            }
        }
        public IRepository<Аccommodation> Аccommodations
        {
            get
            {
                if (аccommodationRepository == null)
                {
                    аccommodationRepository = new АccommodationRepository(db);
                }
                return аccommodationRepository;
            }
        }
        public IRepository<CategoryDate> CategoryDates
        {
            get
            {
                if (categoryDateRepository == null)
                {
                    categoryDateRepository = new CategoryDateRepository(db);
                }
                return categoryDateRepository;
            }
        }
        public void Save()
        {
            this.db.SaveChanges();
        }
        public void Dispose()
        {
            if (!disposed)
            {
                db.Dispose();
                disposed = true;
            }
        }
    }
}
