

namespace CarRentalAppV2.Services
{
    class BrazilTaxService : ITaxService  /// realizando a interface, implementando a operação prevista
    {
        public double Tax(double amount)
        {
            if (amount <= 100)
                return amount * 0.2;
            else
                return amount * 0.1;
        }
    }
}
