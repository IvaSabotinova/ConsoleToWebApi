using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebApi.Models
{
    [ModelBinder(typeof(CustomModelBinderCountryDetails))]
    public class CountryModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Population { get; set; }

        public int Area { get; set; }
    }
}
