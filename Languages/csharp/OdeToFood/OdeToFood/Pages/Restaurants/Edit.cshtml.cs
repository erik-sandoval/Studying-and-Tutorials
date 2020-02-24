using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using OdeToFood.Core;
using OdeToFood.Data;
using System.Collections.Generic;

namespace OdeToFood {
    public class EditModel : PageModel {
        private readonly IRestaurantData restaurantData;
        private readonly IHtmlHelper htmlHelper;

        [BindProperty]
        public Restaurant Restaurant { get; set; }
        public IEnumerable<SelectListItem> Cuisines { get; set; }

        public EditModel(IRestaurantData restaurantData, IHtmlHelper htmlHelper) {
            this.restaurantData = restaurantData;
            this.htmlHelper = htmlHelper;
        }
        public IActionResult OnGet(int? restaurantId) {

            if (restaurantId.HasValue) {
                Cuisines = htmlHelper.GetEnumSelectList<CuisineType>();
                Restaurant = restaurantData.GetById(restaurantId.Value);
            } else {
                Restaurant = new Restaurant();

            }

            if (Restaurant == null) {
                return RedirectToPage("./NotFound");
            }

            return Page();
        }

        public IActionResult OnPost() {
            if (!ModelState.IsValid) {
                Cuisines = htmlHelper.GetEnumSelectList<CuisineType>();
                return Page();
            }

            if (Restaurant.Id > 0) {
                restaurantData.Update(Restaurant);
            } else {
                restaurantData.Add(Restaurant);
            }
            restaurantData.Commit();
            TempData["Message"] = "Restaurant Saved!";
            return RedirectToPage("./Detail", new { restaurantId = Restaurant.Id });
        }
    }
}