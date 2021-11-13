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
    class CategoryDateService
    {
        IHotelUW db;
        public CategoryDateService(IHotelUW db)
        {
            this.db = db;
        }

        public CategoryDateDTO CreateCategoryDateDTO(Guid id)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<CategoryDate, CategoryDateDTO>()).CreateMapper();

            return mapper.Map<CategoryDate, CategoryDateDTO>(db.CategoryDates.Get(id));
        }
        public IEnumerable<CategoryDateDTO> GetCategoryDateDTO()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Guest, GuestDTO>()).CreateMapper();

            return mapper.Map<IEnumerable<CategoryDate>, List<CategoryDateDTO>>(db.CategoryDates.GetAll());
        }

        public void UpdateCategoryDatetDTO(CategoryDateDTO categoryDate)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<CategoryDate, CategoryDateDTO>()).CreateMapper();

            return mapper.Map<GuestDTO, Guest>(db.CategoryDates.Update(categoryDate));
        }

        public void DeleteCategoryDateDTO(Guid id)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<CategoryDate, CategoryDateDTO>()).CreateMapper();

            return mapper.Map<CategoryDate, CategoryDateDTO>(db.CategoryDates.Delete(id));
        }
    }
}
