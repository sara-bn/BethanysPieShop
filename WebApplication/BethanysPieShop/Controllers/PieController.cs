﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Services;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }


        public IActionResult List()
        {
            PieVM pieVM = new PieVM();
            pieVM.Pies = _pieRepository.AllPies();

            pieVM.CurrentCategory = "Cheese cakes";
            return View(pieVM);
        }

        public IActionResult Details(int id)
        {
            var pieToShow = _pieRepository.GetPieById(id);
            if (pieToShow == null)
            {
                return NotFound();  
            }
            return View(pieToShow);
        }

    }
}
