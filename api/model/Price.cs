using System.ComponentModel.DataAnnotations;

namespace model
{
    public class Price
    {
        [Required]
        public decimal Value { get; private set; }
        [Required]
        public Currency Currency { get; private set; }

        public Price(decimal value, Currency currency)
        {
            Value = value;
            Currency = currency;
        }
    }
}
