using BethanysPieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Services
{
    public interface IPieRepository
    {
        IEnumerable<Pie> AllPies();
        IEnumerable<Pie> PiesOfTheWeek();
        Pie GetPieById(int pieId);
    }
}
