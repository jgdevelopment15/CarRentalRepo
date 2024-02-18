using System;
using System.Collections.Generic;

namespace CarRental.Data;

public partial class Vehicletype
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
}
