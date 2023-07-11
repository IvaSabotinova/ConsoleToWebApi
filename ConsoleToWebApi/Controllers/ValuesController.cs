using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebApi.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    [Route("[controller]/[action]")] //base url, rest should be appended
    public class ValuesController : ControllerBase
    {
        [Route("~/api/get-all")]
        [Route("~/getall")]
        [Route("~/get-all")] //- when we do not want to use th common controller route
        public string GetAll()
        {
            return "Hello from get all";
        }

        //[Route("api/get-all-authors")]
        //[Route("getall")] - this is not possible
        public string GetAllAuthors()
        {
            return "Hello from get all authors";
        }

        //[Route("books/{id}")]
        [Route("{id}")]
        public string GetById(int id)
        {
            return "Hello " + id;
        }

        //[Route("books/{id}/author/{authorId}")]
        public string GetAuthorAddressById(int id, int authorId)
        {
            return "hello author address " + id + " " + authorId;
        }

        //[Route("search")]
        public string SearchBooks(int id, int authorId, string name, int rating, int price)
        {
            return "hello from search";
        }


    }
}
