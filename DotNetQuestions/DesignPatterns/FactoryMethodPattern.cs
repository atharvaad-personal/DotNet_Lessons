namespace DesignPatterns
{
    //Creates objects without exposing the creation logic, using a common interface.
    public interface IVehicle
    {
        void Drive();
    }

    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a car...");
        }
    }

    public class Bike : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Riding a bike...");
        }
    }

    public static class VehicalFactory
    {
        public static IVehicle GetVehicle(string vehicleType)
        {
            if (vehicleType == "car")
                return new Car();

            return new Bike();
        }

        public static void Main()
        {
            IVehicle v = VehicalFactory.GetVehicle("car");
            v.Drive();
        }
    }
}

