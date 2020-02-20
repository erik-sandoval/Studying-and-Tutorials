using System.Collections;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using OdeToFood.Data;

namespace OdeToFood.Pages.Restaurants {
    public class List : PageModel {
         readonly IConfiguration config;
         readonly IRestaurantData restaurantData;
        
        public string Message { get; set; }
        public IEnumerable Restaurants { get; set; }

        public List(IConfiguration config, IRestaurantData restaurantData) {
            this.config = config;
            this.restaurantData = restaurantData;
        }

        public void OnGet() {
            Message = config["Message"];
            Restaurants = restaurantData.GetAll();
        }
    }
}