using HomeWork;

Vehicle vehicle = new Vehicle(1, "Gol", "Volks");

Car car = new Car(2, "Fox", "Volks", "Popular");

Console.WriteLine(vehicle.GetVehicleDetais());

Console.WriteLine(car.GetVehicleDetais());
Console.WriteLine(car.GetVehicleType());

car.MoveVehicle(300);

