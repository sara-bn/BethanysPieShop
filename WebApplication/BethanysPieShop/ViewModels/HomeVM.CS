using BethanysPieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Pie> PiesOfTheWeek { get; set; }
    }
}
