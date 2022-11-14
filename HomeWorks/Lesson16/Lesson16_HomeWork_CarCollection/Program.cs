using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_HomeWork_CarCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestDriving();
            Console.ReadLine();
        }

        public static void TestDriving()
        {
            Vehicle vehicle = new("AnyVehicle", "rrrrr");
            Cars car = new("Tesla", "iiiii");
            Truck truck = new("Renault", "uuuuu");

            Console.WriteLine("----------------------- GENERIC CLASS----------------------------");
            Drive<Vehicle> driveVehicle = new()
            {
	            SoundDrive = vehicle.SoundDrive,
	            Transport = vehicle
            };
            driveVehicle.Driving();

            Drive<Cars> driveCar = new()
            {
	            SoundDrive = car.SoundDrive,
	            Transport = car
            };
            driveCar.Driving();

            Drive<Truck> driveTruck = new()
            {
	            SoundDrive = truck.SoundDrive,
	            Transport = truck
            };
            driveTruck.Driving();

            Console.WriteLine("----------------------- INVARIANT----------------------------");

            IAnyCollection_Invariant<Vehicle> IColVehicle = new VehicleCollectionInvariant<Vehicle>(vehicle);
            IColVehicle.Show();

            IAnyCollection_Invariant<Cars> IColCars = new VehicleCollectionInvariant<Cars>(car);
            IColCars.Show();

            IAnyCollection_Invariant<Truck> IColTruck = new VehicleCollectionInvariant<Truck>(truck);
            IColTruck.Show();

            Console.WriteLine("----------------------- COVARIANT----------------------------");

            IAnyCollection_Covariant<Vehicle> colVehicle = new VehicleCollectionCovariant<Vehicle>(vehicle);
            colVehicle.Show();

            colVehicle = new VehicleCollectionCovariant<Cars>(car);
            colVehicle.Show();

            colVehicle = new VehicleCollectionCovariant<Truck>(truck);
            colVehicle.Show();

            Console.WriteLine("----------------------- CONTRAVARIANT----------------------------");
            IAnyCollection_Contravariant<Cars> colCars = new VehicleCollectionContravariant<Cars>(car);
            colCars.Show();

            colCars = new VehicleCollectionContravariant<Vehicle>(vehicle);
            colCars.Show();
        }
    }
}
