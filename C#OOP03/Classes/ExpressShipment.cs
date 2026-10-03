

using C_OOP03.Struct;

namespace C_OOP03.Classes
{
    /// <summary>
    /// Represents an express shipment with an additional extra fee.
    /// </summary>
    internal class ExpressShipment : Shipment
    {
        decimal extraFee;

        #region Property

        public decimal ExtraFee
        {
            get { return extraFee; }
            set { if (value >= 0) extraFee = value; }
        }

        #endregion

        public override decimal EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5) + ExtraFee; }

        }

        public ExpressShipment(string _trackingCode, string _description, decimal _weight,
            decimal _deliveryFee, DeliveryAddress _destination, decimal _extraFee)
            : base(_trackingCode, _description, _weight, _deliveryFee, _destination)
        {
            ExtraFee = _extraFee;

        }

        public override void PrintShipment()
        {
            Console.WriteLine("--- Express Shipment ---");
            base.PrintShipment();
            Console.WriteLine($"Extra Fee: {ExtraFee} EGP");
        }

    }
}
