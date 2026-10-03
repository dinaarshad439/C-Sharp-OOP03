

using C_OOP03.Struct;

namespace C_OOP03.Classes
{
    internal sealed class CompletedShipment:Shipment
    {
        public CompletedShipment(string _trackingCode, string _description,
            decimal _weight, decimal _deliveryFee, DeliveryAddress _destination)
            : base(_trackingCode, _description, _weight, _deliveryFee, _destination) { }


    }
}
