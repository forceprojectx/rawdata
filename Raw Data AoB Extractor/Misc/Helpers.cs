using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Raw_Data_AoB_Extractor.Misc
{
    class Helpers
    {
        /// <summary>
        /// create a regularly spaced hex string eg; '03 04 05 06'
        /// </summary>
        /// <param name="hex"></param>
        /// <returns>hex string, string.Empty if input null or whitespace</returns>
        public static string HexToSpacedHex(string hexString)
        {
            if (string.IsNullOrWhiteSpace(hexString)) { return string.Empty; }
            

            hexString = hexString.Replace(" ", string.Empty);
            if (hexString.Length % 2 == 1) { hexString = "0" + hexString; }
            int hexStringLength = hexString.Length-1;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hexStringLength; i += 2)
            {
                sb.Append(hexString[i]);
                sb.Append(hexString[i + 1]);
                sb.Append(' ');
            }
            return sb.ToString();
        }
    }
}
