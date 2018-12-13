using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataProvider;
using Microsoft.AspNetCore.Mvc;

namespace ViewComponentDemo.Pages.Components.FruitsBasket
{
    public class FruitsBasketViewComponent : ViewComponent
    {
        private IFruitRepository _repo;

        public FruitsBasketViewComponent(IFruitRepository repo)
        {
            _repo = repo;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var fruits = _repo.GetFruits();
            return View(fruits);
        }
    }
}
