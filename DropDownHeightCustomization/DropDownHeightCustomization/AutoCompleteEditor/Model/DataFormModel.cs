using System.ComponentModel.DataAnnotations;

namespace DropDownHeightCustomization
{
    public class DataFormModel
    {
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Purpose { get; set; }
    }
}
