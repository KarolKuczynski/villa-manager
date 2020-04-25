namespace model
{
    public enum Currency
    {
        [CurrencyDescriptor("\u20AC")]
        Euro = 1,
        [CurrencyDescriptor("$")]
        Dolar = 2,
        [CurrencyDescriptor("\u00A3")]
        Pound = 3,
        [CurrencyDescriptor("zł")]
        Zloty = 4
    }
}
