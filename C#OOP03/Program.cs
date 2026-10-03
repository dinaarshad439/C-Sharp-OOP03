using C_OOP03.Classes;
using C_OOP03.Classes;
using C_OOP03.Struct;
using System.Net;

namespace C_OOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Theoretical Questions

            #region (Q1) Overloading, Overriding & Binding

            // (a)
            /*
             * Method Overloading:
             * Defining multiple methods with the same name but different parameter lists.
             * 
             * Method coverriding:
             * Providing a new implementation for an inherited Method.
             */

            //---------------------------------------------------

            // (b)
            /*
             *  Static Binding:
             *  1) compilation time
             *  2) occurs with method hiding using [new]
             *  3) call method based on reference [parent]
             *  
             *  
             *   Dynamic Binding:
             *   1) Run time
             *   2) Occurs with [override] and virtual methods
             *   3) call method based on object [child]
             */


            #endregion

            #region (Q2) Sealed Classes and Methods

            // (a)
            /*
             *  its means that it Prevents other classes from inheriting
             */

            // (b)
            /*
             * Sealed class:
             * Prevents a class from being inherited.
             *
             * Sealed method:
             * Prevents a method from being overridden in a derived class.
             */

            // (c)
            /*
             * No,a sealed method cannot be overridden again because
             * the sealed keyword prevents further overriding
             */
            #endregion


            #endregion

            #region Practical Questions

            //a,b,c
            Console.WriteLine("=============================================");
            Console.WriteLine("Delivery center");
            Console.WriteLine("=============================================");
            
            string Driver = "Ahmed mohamed";
            DeliveryCenter center=new DeliveryCenter(Driver);
            Console.WriteLine($"Driver: {Driver}");

            //d
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Enter the standard shipment");
            ReadShipmentData(
                out string? trackingCode,
                out string? description,
                out decimal weight,
                out decimal deliveryFee,
                out DeliveryAddress destination
);

            StandardShipment standard = new StandardShipment(
                trackingCode,
                description,
                weight,
                deliveryFee,
                destination
            );


            //e
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Enter the express shipment");
            ReadShipmentData(
                 out trackingCode,
                 out description,
                 out weight,
                 out deliveryFee,
                 out destination
);

            Console.WriteLine("Enter Extra Fee:");
            decimal extraFee = decimal.Parse(Console.ReadLine());

            ExpressShipment express = new ExpressShipment(
                trackingCode,
                description,
                weight,
                deliveryFee,
                destination,
                extraFee

            );



             //f
            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine("Enter the international shipment");
            ReadShipmentData(
              out trackingCode,
              out description,
              out weight,
              out deliveryFee,
              out destination
            );

            Console.WriteLine("Enter Destination Country:");
            string? destinationCountry = Console.ReadLine();

            Console.WriteLine("Enter Customs Fee:");
            decimal customsFee = decimal.Parse(Console.ReadLine());

            InternationalShipment international = new InternationalShipment(
                trackingCode,
                description,
                weight,
                deliveryFee,
                destination,
                destinationCountry,
                customsFee
            );

            //g
            center.AddShipment(standard);
            center.AddShipment(express);
            center.AddShipment(international);

            //h
            center.PrintAllShipments();

            //i
            Console.WriteLine("=======================================================");
            Console.WriteLine("Printing using DeliveryHelper..........");
            DeliveryHelper.PrintShipmentDetails(standard);
            Console.WriteLine("------------------");
            DeliveryHelper.PrintShipmentDetails(express);
            Console.WriteLine("------------------");
            DeliveryHelper.PrintShipmentDetails(international);

           
            //j
            Console.WriteLine("=======================================================");
            Console.WriteLine("Updating Weight..........");

            Console.WriteLine($"Original weight: {standard.Weight} kg");

            Console.Write("Enter updated weight: ");
            decimal newWeight = decimal.Parse(Console.ReadLine()!);

            standard.Weight_Update(newWeight);
            Console.WriteLine($"Updated Weight: {standard.Weight} kg");

            standard.Weight_Update(2); 
            Console.WriteLine($"Updated Weight After Packing: {standard.Weight} kg");

            //k
            Console.WriteLine("=======================================================");
            Console.WriteLine("Printing Using Shipment[]........");

            Shipment[] array=new Shipment[] { standard,express,international };
            foreach(Shipment sh in array)
            {
                sh.PrintShipment();
                Console.WriteLine();
            }

            //l
            Console.WriteLine("=======================================================");
            Console.WriteLine("Demonstrating Sealed Class & Sealed Method..........");

            
            CompletedShipment completed = new CompletedShipment("CMP999", "Delivered Package", 3, 20, destination);
            completed.PrintShipment();

            
            PriorityInternationalShipment priority = new PriorityInternationalShipment(
                "PRI777", "Express VIP", 5, 100, destination, "Germany", 200
            );
            priority.GenerateCustomsReport();

            // Note: 
            // - CompletedShipment is SEALED -> cannot be inherited.
            // - PriorityInternationalShipment.GenerateCustomsReport() is SEALED -> cannot be overridden in derived classes.

            #endregion

        }

        public static void ReadShipmentData(
           out string? trackingCode,
           out string? description,
           out decimal weight,
           out decimal deliveryFee,
           out DeliveryAddress destination)
        {
            Console.WriteLine("Enter tracking code:");
            trackingCode = Console.ReadLine();

            Console.WriteLine("Enter description:");
            description = Console.ReadLine();

            Console.WriteLine("Enter weight:");
            weight = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter delivery fee:");
            deliveryFee = decimal.Parse(Console.ReadLine());



            Console.WriteLine("Enter City:");
            string? city = Console.ReadLine();

            Console.WriteLine("Enter street:");
            string? street = Console.ReadLine();

            bool flag = false;
            int buildingNumber;

            do
            {
                Console.WriteLine("Enter building number:");
                flag = int.TryParse(Console.ReadLine(), out buildingNumber);

            } while (!flag);

            destination = new DeliveryAddress(city, street, buildingNumber);
        }

    
    }
}
