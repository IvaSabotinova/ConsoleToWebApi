using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Primitives;

namespace ConsoleToWebApi
{
    public class CustomBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            IQueryCollection data = bindingContext.HttpContext.Request.Query;

            //countries is the name of the query string that we will use in our URL
            bool result = data.TryGetValue("countries", out StringValues country);

            if (result)
            {
                string[] array = country.ToString().Split('|');

                bindingContext.Result = ModelBindingResult.Success(array);
            }

            return Task.CompletedTask; 

        }
    }
}
