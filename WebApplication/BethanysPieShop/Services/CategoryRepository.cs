using BethanysPieShop.DbHelper;
using BethanysPieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Services
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly StoreDbContext _dbContext;

        public CategoryRepository(StoreDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }
        public IEnumerable<Category> AllCategories()
        {
            return _dbContext.Categories.ToList();
        }
    }
}
