using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Raw_Data_AoB_Extractor.Java
{
    class JOpCode
    {
        public string Name { get; set; }
        public string OpCode { get; set; }
        public int OperandCount { get; set; }


        public JOpCode() { }
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="n">the mnemonic of the opcode</param>
        /// <param name="code">the hex bytecode for the mnemonic</param>
        /// <param name="count">the number of operands</param>
        public JOpCode(string n, string code, string count)
        {
            Name = n;
            OpCode = code;
            try
            {
                OperandCount = Convert.ToInt32(count);
            }
            catch(Exception e)
            {
                OperandCount = 0;
                throw e;
            }
        }
    }
}
