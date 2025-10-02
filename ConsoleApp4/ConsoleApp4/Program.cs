namespace ConsoleApp4
{
    internal class Program
    {

        /* TASK (analyzed)

         Create an interface IDriveable with methods:
         StartEngine(); Drive()

         Create an abstract class Vehicle with:
         Properties: Make, Model.
         Abstract method: DisplayInfo().
         Implement two classes:
         Car (inherits Vehicle, implements IDriveable).
         Motorcycle (inherits Vehicle, implements IDriveable).

         IN MAIN
         Create a List<IDriveable> with Car and Motorcycle objects. Call StartEngine(), Drive(), and DisplayInfo() for each.
         */
        interface IDrivable
        {
            void StartEngine();
            void Drive();
        }

        abstract class Vehicle
        {
            public string Model { get; set; }
            public string Make { get; set; }

            public abstract void DisplayInfo();
        }

        class Car : Vehicle, IDrivable
        {
            public override void DisplayInfo()
            {
                Console.WriteLine($"This car model is {Model} and it was manufactured by {Make}");
            }

            public void Drive()
            {
                Console.WriteLine($"This car is {Make} {Model} and it is now driving");
            }
            public void StartEngine()
            {
                Console.WriteLine($"The engine of this car is now started. This car is {Make} {Model} and its amazing!!");
            }
        }

        class Motorbike : Vehicle, IDrivable
        {
            public override void DisplayInfo()
            {
                Console.WriteLine($"This motorbike model is {Model} and it was manufactured by {Make}");
            }

            public void Drive()
            {
                Console.WriteLine($"This motorbike is {Make} {Model} and it is now driving");
            }

            public void StartEngine()
            {
                Console.WriteLine("This motorbike is now started");
            }
        }

        static int GetAmountOfVehicles(string vehicleType)
        {
            int amount;
            do
            {
                Console.WriteLine($"How many {vehicleType}s do you want to enter? ");
                amount = int.Parse(Console.ReadLine());
            } while (amount < 0);
            return amount;
        }

        static (string manufacturer, string model) GetVehicleInfo(string vehicleType)
        {
            Console.WriteLine($"Enter the manufacturer of the {vehicleType}:");
            string manufacturer = Console.ReadLine();
            Console.WriteLine($"Enter the model of the {vehicleType}:");
            string model = Console.ReadLine();
            return (manufacturer, model);
        }

        static void Main(string[] args)
        {
            List<IDrivable> drivables = new List<IDrivable>();
            Vehicle car = new Car();
            Vehicle motorbike = new Motorbike();

            int amountOfVehicles, amountOfCars, amountOFMotorbikes;

            amountOfVehicles = GetAmountOfVehicles("vehicle");
            amountOfCars = GetAmountOfVehicles("car");
            amountOFMotorbikes = GetAmountOfVehicles("motorbike");

            if (amountOfCars > 0)
            {
                for (int i = 0; i < amountOfCars; i++)
                {
                    var carInfo = GetVehicleInfo("car");
                    drivables.Add(new Car { Make = carInfo.manufacturer, Model = carInfo.model });
                }
            }

            if (amountOFMotorbikes > 0)
            {
                for (int i = 0; i < amountOFMotorbikes; i++)
                {
                    var motorbikeInfo = GetVehicleInfo("motorbike");
                    drivables.Add(new Motorbike { Make = motorbikeInfo.manufacturer, Model = motorbikeInfo.model });
                }
            }

            for (int i = 0; i < amountOfVehicles; i++)
            {
                drivables[i].StartEngine();
                drivables[i].Drive();

                // below is AI generated code.
                if (i < amountOfCars)
                {
                    ((Vehicle)drivables[i]).DisplayInfo();
                }
                else
                {
                    ((Vehicle)drivables[i]).DisplayInfo();
                }
                // AI generated code ends here.
            }

            //foreach (var drivable in drivables)
            //{
            //    drivable.StartEngine();
            //    drivable.Drive();
            //    Console.WriteLine();
            //    if (drivable.Equals(car))
            //    {
            //        car.DisplayInfo();
            //    }
            //    else if(drivable.Equals(motorbike))
            //    {
            //        motorbike.DisplayInfo();
            //    }




        }
    }
}

