using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLibrary
{
    /// <summary>
    /// Extends the base Customer class
    /// </summary>
    public static class ExtensionCustomer
    {
        /// <summary>
        /// This method allow to represent customer in different ways.
        /// </summary>
        /// <param name="customer">Link to the customer object</param>
        /// <param name="format">Customer's format</param>
        /// <param name="provider">Parameter to control formatting</param>
        /// <returns>String which represent customer instance.</returns>
        public static string Print(this Customer customer, string format, IFormatProvider provider)
        {
            if (String.IsNullOrEmpty(format))
                format = "S+";

            if (provider == null)
                provider = CultureInfo.CurrentCulture;

            switch (format.ToUpperInvariant())
            {
                case "S+":
                    return string.Format("Customer info. Name:{0}, Contact phone:{1}, Revenue:{2}", customer.Name, customer.ContactPhone, customer.Revenue);
                case "S++":
                    return string.Format("Customer info.\nName:{0}\nContact phone:{1}\nRevenue:{2}", customer.Name, customer.ContactPhone, customer.Revenue);
            }

            throw new FormatException("Unsupported format: " + format);
        }
    }
}
