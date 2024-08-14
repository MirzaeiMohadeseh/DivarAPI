using System.Text.RegularExpressions;
namespace DivarAPI.Entities
{
    

    public class Divar
    {
        public int ID { get; set; }
        public required string Title { get; set; }
        public string Category { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public required decimal Price { get; set; }
        public string ImagePath { get; set; }= string.Empty;
        public string City { get; set; } = string.Empty;

        public DateTime CreationDate { get; set; } = DateTime.Now;
    }
}
