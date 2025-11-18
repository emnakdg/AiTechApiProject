using AiTech.Entity.Entities.Common;

namespace AiTech.Entity.Entities
{
    public class Testimonial : BaseEntity
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string PhotoUrl { get; set; }
        public string Comment { get; set; }
    }
}
