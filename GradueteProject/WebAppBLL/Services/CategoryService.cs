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
    class CategoryService
    {
        IHotelUW db;
        public CategoryService(IHotelUW db)
        {
            this.db = db;
        }

        public CategoryDTO CreateCategoryDTO(Guid id)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Category, CategoryDTO>()).CreateMapper();

            return mapper.Map<Category, CategoryDTO>(db.Categories.Get(id));
        }
        public IEnumerable<CategoryDTO> GetCategoryDTO()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Category, CategoryDTO>()).CreateMapper();

            return mapper.Map<IEnumerable<Category>, List<CategoryDTO>>(db.Categories.GetAll());
        }

        public void UpdateCategoryDTO(CategoryDTO category)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Category, CategoryDTO>()).CreateMapper();

            return mapper.Map<CategoryDTO, Category>(db.Guests.Update(category));
        }

        public void DeleteCategoryDTO(Guid id)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Category, CategoryDTO>()).CreateMapper();

            return mapper.Map<Category, CategoryDTO>(db.Guests.Delete(id));
        }
    }
}
