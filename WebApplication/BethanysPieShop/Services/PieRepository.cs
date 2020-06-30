using BethanysPieShop.DbHelper;
using BethanysPieShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Services
{
    public class PieRepository : IPieRepository
    {
        private readonly StoreDbContext _dbContext;

        public PieRepository(StoreDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }
        public IEnumerable<Pie> AllPies()
        {

            return _dbContext.Pies.Include(c => c.Category);
            
        }

        public IEnumerable<Pie> PiesOfTheWeek()
        {
           return _dbContext.Pies.Include(c => c.Category).Where(p => p.IsPieOfTheWeek);
        }


        public Pie GetPieById(int pieId)
        {
           return _dbContext.Pies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}