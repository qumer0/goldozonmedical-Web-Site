

namespace goldozonmedical_Web_Site.Models
{
    public class Distributors
    {
        
        public string? city { get; set; }
        public string? district { get; set; }
        public string? adress {get; set;}
        public string? tel {get; set;}
        public string? name {get; set;}
    }
    

    public class City
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }

    public class District
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int CityId { get; set; } // Şehir ile ilişkilendirme
    }
}


