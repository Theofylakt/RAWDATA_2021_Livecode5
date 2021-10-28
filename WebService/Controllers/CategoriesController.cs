using DataServiceLib;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService.Controllers
{
    [ApiController]
    [Route("api/categories")]
    public class CategoriesController : Controller
    {

        IDataService dataService = new DataService();
               
        [HttpGet]
        public JsonResult GetCategories()
        {
            var categories = dataService.GetCategories();
            return new JsonResult(categories);
        }

        // api/categories/id
        [HttpGet("{id}")]
        public JsonResult GetCategory(int id)
        {
            var category = dataService.GetCategory(id);

            return new JsonResult(category);
        }
        
        
    }
}
