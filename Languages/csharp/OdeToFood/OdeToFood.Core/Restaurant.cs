using System.ComponentModel.DataAnnotations;

namespace OdeToFood.Core {
    public class Restaurant {
        public int Id { get; set; }
        [Required, StringLength(80, ErrorMessage = "Max Length is 80 Characters")]
        public string Name { get; set; }
        [Required, StringLength(255, ErrorMessage = "Max Length is 255 Characters")]
        public string Location { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
