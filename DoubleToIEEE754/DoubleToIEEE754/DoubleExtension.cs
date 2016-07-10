using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleToIEEE754
{
    /// <summary>
    /// This is an extension class for System.Double which provides converting methods to IEEE 754 standard.
    /// </summary>
    public static class DoubleExtension
    {
        /// <summary>
        /// This method convert double into string which represents it in IEEE 754 using BitConverter. 
        /// </summary>
        /// <param name="db">Double number which must be converted</param>
        /// <returns>String representation of double in IEEE 754</returns>
        public static string ToIEEE754UsingBitConverter(this Double db)
        {
            var bitArray = new BitArray(BitConverter.GetBytes(db));
            StringBuilder res = new StringBuilder(64);

            for (int i = bitArray.Length - 1; i >= 0; i--)
            {
                if (bitArray[i] == false)
                    res.Append('0');
                else
                    res.Append('1');
            }

            return res.ToString();
        }

        /// <summary>
        /// This method convert double into string which represents it in IEEE 754. 
        /// </summary>
        /// <param name="db">Double number which must be converted</param>
        /// <returns>String representation of double in IEEE 754</returns>
        public static string ToIEEE754(this double db)
        {
            throw new NotImplementedException();
        }
    }
}


