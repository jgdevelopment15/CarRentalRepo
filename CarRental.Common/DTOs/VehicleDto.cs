namespace CarRental.Common.DTOs
{
    public class VehicleDto
    {
        public int Id { get; set; }

        public string VehicleType { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public string Color { get; set; }

        public decimal PricePerDay { get; set; }

        public string Location { get; set; }

        
    }
}
