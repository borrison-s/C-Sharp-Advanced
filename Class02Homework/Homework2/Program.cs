using Homework2.Domain.Models;

CarCenter carCenter = new CarCenter();
Car car = new Car("Toyota", "Corolla", 2021, 2500);
Truck truck = new Truck("Ford", "F150", 2018, 5000);

carCenter.WashCar(car);
carCenter.WashTrailer(truck);
carCenter.PumpGas(car);
carCenter.PumpGas(truck);
carCenter.CheckVehicle(car);
carCenter.CheckVehicle(truck);
carCenter.FixVehicle(car);
carCenter.FixVehicle(truck);
