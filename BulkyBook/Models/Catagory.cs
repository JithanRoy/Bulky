using Microsoft.AspNetCore.Mvc;

namespace BulkyBook.Models
{
    public class Catagory : Controller
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
