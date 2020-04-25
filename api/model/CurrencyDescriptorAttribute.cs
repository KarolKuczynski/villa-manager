using System;

namespace model
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class CurrencyDescriptorAttribute : Attribute
    {
        public string Symbol { get; }
      
        public CurrencyDescriptorAttribute(string symbol)
        {
            Symbol = symbol;
        }
    }
}
