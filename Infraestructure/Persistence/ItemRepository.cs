﻿using Microsoft.EntityFrameworkCore;
using Store_Backend.Application.Dtos;
using Store_Backend.Domain.Entities;
using Store_Backend.Domain.Persistence;

namespace Store_Backend.Infraestructure.Persistence
{
    public class ItemRepository : GenericRepository<Item>, IItemRepository
    {
        private StoreContext _storeContext;

        public ItemRepository(StoreContext storeContext) : base(storeContext)
        {
            _storeContext = storeContext;
        }

        public virtual Item GetById(long id)
        {
            var entity = _storeContext.Items.Include(i => i.Category).SingleOrDefault(i => i.Id == id);
            if (entity == null) throw new ElementNotFoundException();
            return entity;
        }

        public List<ItemDto> GetByCategoryId(long categoryId)
        {
            var items = _dbSet.Where(i => i.CategoryId == categoryId)
                .Select(i => new ItemDto
                {
                    Id = i.Id,
                    Name = i.Name,
                    Description = i.Description,
                    Price = i.Price,
                    Image = i.Image,
                    CategoryId = categoryId,
                    CategoryName = i.Category.Name
                }).ToList();

            if (items == null) return new List<ItemDto>();
            return items.ToList();
        }

        public override Item Insert(Item item)
        {
            _storeContext.Items.Add(item);
            _storeContext.SaveChanges();
            _storeContext.Entry(item).Reference(i => i.Category).Load();
            return item;
        }

        public override Item Update(Item item)
        {
            _storeContext.Items.Update(item);
            _storeContext.SaveChanges();
            _storeContext.Entry(item).Reference(i => i.Category).Load();
            return item;
        }
    }
}