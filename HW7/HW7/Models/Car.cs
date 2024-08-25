namespace HW7.Models;
public class Car
{
    public string CarBrand { get; set; }
    public string CarModel { get; set; }
    public string YearOfManufacturing { get; set; }
    public double EngineCapacity { get; set; }
    public string CountryOfManufacturing { get; set; }
    public int Id { get; internal set; }
}

