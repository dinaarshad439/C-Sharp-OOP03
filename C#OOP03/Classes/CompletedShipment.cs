

using C_OOP03.Struct;

namespace C_OOP03.Classes
{
    /// <summary>
    /// Represents a completed shipment.
    /// Inherits common shipment information and behavior from the Shipment class.
    /// </summary>
    internal sealed class CompletedShipment:Shipment
    {
        public CompletedShipment(string _trackingCode, string _description,
            decimal _weight, decimal _deliveryFee, DeliveryAddress _destination)
            : base(_trackingCode, _description, _weight, _deliveryFee, _destination) { }


    }
}
