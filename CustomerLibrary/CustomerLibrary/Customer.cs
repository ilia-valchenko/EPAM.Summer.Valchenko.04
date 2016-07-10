using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLibrary
{
    /// <summary>
    /// Class Customer contains general information about customer.
    /// </summary>
    public class Customer : IFormattable
    {
        /// <summary>
        /// Name property contains value of customer's name.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// ContactPhone property contains value of customer's phone number.
        /// </summary>
        public string ContactPhone { get; }
        /// <summary>
        /// Revenue property contains value of customer's revenue.
        /// </summary>
        public decimal Revenue { get; }

        /// <summary>
        /// The class standard constructor.
        /// </summary>
        public Customer() { }

        /// <summary>
        /// The class constructor with parameters.
        /// </summary>
        public Customer(string name, string phone, decimal revenue)
        {
            Name = name;
            ContactPhone = phone;
            Revenue = revenue;
        }

        /// <summary>
        /// This method allow to represent customer in different ways.
        /// </summary>
        /// <param name="format">Customer's format</param>
        /// <param name="provider">Parameter to control formatting</param>
        /// <returns>String which represent customer instance.</returns>
        public string ToString(string format = "S", IFormatProvider provider = null)
        {
            if (String.IsNullOrEmpty(format))
                format = "S";

            if (provider == null)
                provider = CultureInfo.CurrentCulture;

            switch (format.ToUpperInvariant())
            {
                case "S":
                    return string.Format("Customer: {0}, {1}, {2}", Name, ContactPhone, Revenue);
                case "N":
                    return string.Format("Customer: {0}", Name);
                case "NP":
                    return string.Format("Customer: {0}, {1}", Name, ContactPhone);
                case "NPR":
                    return string.Format("Customer: {0}, {1}, {2}", Name, ContactPhone, Revenue);
                case "P":
                    return string.Format("Customer: {0}", ContactPhone);
                case "R":
                    return string.Format("Customer: {0}", Revenue);
            }

            throw new FormatException("Unsupported format: " + format);
        }
    }
}
