

using C_OOP03.Struct;

namespace C_OOP03.Classes
{
    internal class PriorityInternationalShipment:InternationalShipment
    {
        public PriorityInternationalShipment(string _trackingCode, string _description,
            decimal _weight, decimal _deliveryFee, DeliveryAddress _destination, string _destinationCountry, decimal _customFee)
            : base(_trackingCode, _description, _weight, _deliveryFee, _destination, _destinationCountry, _customFee) { }

        public override sealed void GenerateCustomsReport() 
        {
            Console.WriteLine($"Cutom report generated fo{DestinationCountry} with fee: {CustomsFee}");
        }
    }
}
