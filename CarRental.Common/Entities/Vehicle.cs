using System;
using System.Collections.Generic;

namespace CarRental.Data;

public partial class Vehicle
{
    public int Id { get; set; }

    public int? VehicleTypeId { get; set; }

    public string? Make { get; set; }

    public string? Model { get; set; }

    public int? Year { get; set; }

    public string? Color { get; set; }

    public decimal? PricePerDay { get; set; }

    public bool? IsRented { get; set; }

    public int? LocationId { get; set; }

    public virtual Location? Location { get; set; }

    public virtual Vehicletype? VehicleType { get; set; }
}
