using System;
using System.Collections.Generic;

namespace CarRental.Data;

public partial class Location
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Country { get; set; }

    public virtual ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
}
