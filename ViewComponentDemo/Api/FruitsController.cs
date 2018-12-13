using DataProvider;
using Microsoft.AspNetCore.Mvc;

namespace ViewComponentDemo.Api
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FruitsController : ControllerBase
    {
        private IFruitRepository _repo;

        public FruitsController(IFruitRepository repo)
        {
            _repo = repo;
        }
        // GET api/fruits/get
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repo.GetFruits());
        }

        // GET api/fruits/getselected
        [HttpGet]
        public IActionResult GetSelected()
        {
            return Ok(_repo.GetSelectedFruits());
        }

        // POST api/fruits/post
        public void Post([FromForm] int[] selected)
        {
            var x = HttpContext;
            _repo.SelectFruits(selected);
        }
    }
}