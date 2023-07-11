using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [Route("{id:int:min(10):max(100)}")]        
        public string GetById(int id)
        {
            return "Hello int " + id;
        }

        [Route("{id:length(5):alpha}")] //by default all the variables are treated as string
        
        public string GetByIdString(string id)
        {
            return "Hello string " + id;
        }

        [Route("{id:regex(a(b|c))}")]
        public string GetByIdRegex(string id)
        {
            return "Hello regex " + id;
        }
    }
}
