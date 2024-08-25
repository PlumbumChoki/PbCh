using HW7.Models;
using HW7.Data;
using Microsoft.EntityFrameworkCore;

namespace HW7.Repositories;

public class RepositoryDB
{
    public async Task<List<Car>> GetAllCars()
    {
        using var carContext = new CarContext();
        return await carContext.Car.ToListAsync();
    }
    public async Task AddCarsAsync(Car car)
    {
        using var carContext = new CarContext();
        carContext.Car.Remove(car);
        await carContext.SaveChangesAsync();
    }
    public async Task RemoveCarsAsync(Car car)
    {
        using var carContext = new CarContext();
        await carContext.Car.AddAsync(car);
        await carContext.SaveChangesAsync();
    }

    public async Task UpdateCarsAsync(int id, Car car)
    {
        using var carContext = new CarContext();
        var updatingCar = await carContext.Car.FirstAsync(x => x.Id == id);
        updatingCar.CarBrand = car.CarBrand;
        updatingCar.CarModel = car.CarModel;
        updatingCar.YearOfManufacturing = car.YearOfManufacturing;
        updatingCar.EngineCapacity = car.EngineCapacity;
        updatingCar.CountryOfManufacturing = car.CountryOfManufacturing; 

        
        await carContext.SaveChangesAsync();

    }
}

