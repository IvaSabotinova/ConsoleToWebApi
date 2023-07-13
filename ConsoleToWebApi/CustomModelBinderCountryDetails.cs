using ConsoleToWebApi.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ConsoleToWebApi
{
    public class CustomModelBinderCountryDetails : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            string modelName = bindingContext.ModelName;
            ValueProviderResult value = bindingContext.ValueProvider.GetValue(modelName);
            string? result = value.FirstValue;

            if(!int.TryParse(result, out int id))
            {
                return Task.CompletedTask;
            }

            CountryModel model = new CountryModel()
            {
                Id = id,
                Name = "India",
                Area = 400,
                Population = 500,                 
            };

            bindingContext.Result = ModelBindingResult.Success(model);

            return Task.CompletedTask;
        }
    }
}
