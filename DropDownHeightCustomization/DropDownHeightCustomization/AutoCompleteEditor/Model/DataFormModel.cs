using System.ComponentModel.DataAnnotations;

namespace DropDownHeightCustomization
{
    public class DataFormModel
    {
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Purpose { get; set; } = string.Empty;
    }
}