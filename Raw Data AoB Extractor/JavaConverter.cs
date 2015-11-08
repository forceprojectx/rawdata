using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

using System.Windows.Forms;
using Raw_Data_AoB_Extractor.Java;

namespace Raw_Data_AoB_Extractor
{
    public partial class JavaConverter : Form
    {
        /// <summary>
        /// table containing the mnemonics and their opcodes. 
        /// {String, JOpCode}
        /// </summary>
        internal Hashtable codeTable = new Hashtable();

        Form1 parentForm = null;
        public JavaConverter()
        {
            InitializeComponent();
            cb_autoclose.Checked = Properties.Settings.Default.unity_autoclose;
            cb_metadata.Checked = Properties.Settings.Default.unity_keepMetadata;
            cb_resolveBranches.Checked = Properties.Settings.Default.unity_resolveBranches;
            populateTable();
        }

        public JavaConverter(Form1 frm):this()
        {            
            parentForm = frm;
        }

        #region hash table codes
        private void getCodesFromWiki()
        {
            //tb_data.Text = "";
            //StringBuilder data = new StringBuilder();

            

            //HtmlElementCollection table = webBrowser1.Document.GetElementsByTagName("table");
            //HtmlElementCollection trows = table[0].GetElementsByTagName("tr");
            //data.Append( trows.Count + Environment.NewLine);
            //foreach (HtmlElement row in trows)
            //{
            //    //data += row.InnerText+Environment.NewLine;
            //    HtmlElementCollection tcols = row.GetElementsByTagName("td");
            //    //key, value
            //    if (tcols.Count >= 5)
            //    {
            //        int byteCount = 0;
            //        try
            //        {
            //            byteCount = Convert.ToInt32(Regex.Match(tcols[3].InnerText, @"^(\d):").Groups[1].Value);
            //        }
            //        catch { }

                    

            //        data.AppendFormat("codeTable.Add(\"{0}\",\t",tcols[0].InnerText);
            //        data.AppendFormat("new JOpCode(\"{0}\", \"{1}\", \"{2}\")",
            //            tcols[0].InnerText,
            //            tcols[1].InnerText,
            //            byteCount
            //            );
            //        data.AppendFormat(");//{0}{1}",tcols[5].InnerText, Environment.NewLine);



                    
            //    }
            //}
            //tb_data.Text = data.ToString();
        }
        private void populateTable()
        {

            codeTable.Add("nop", new JOpCode("nop", "00", "0"));//perform no operation
            codeTable.Add("aconst_null", new JOpCode("aconst_null", "01", "0"));//push a null reference onto the stack
            codeTable.Add("iconst_m1", new JOpCode("iconst_m1", "02", "0"));//load the int value −1 onto the stack
            codeTable.Add("iconst_0", new JOpCode("iconst_0", "03", "0"));//load the int value 0 onto the stack
            codeTable.Add("iconst_1", new JOpCode("iconst_1", "04", "0"));//load the int value 1 onto the stack
            codeTable.Add("iconst_2", new JOpCode("iconst_2", "05", "0"));//load the int value 2 onto the stack
            codeTable.Add("iconst_3", new JOpCode("iconst_3", "06", "0"));//load the int value 3 onto the stack
            codeTable.Add("iconst_4", new JOpCode("iconst_4", "07", "0"));//load the int value 4 onto the stack
            codeTable.Add("iconst_5", new JOpCode("iconst_5", "08", "0"));//load the int value 5 onto the stack
            codeTable.Add("lconst_0", new JOpCode("lconst_0", "09", "0"));//push the long 0 onto the stack
            codeTable.Add("lconst_1", new JOpCode("lconst_1", "0a", "0"));//push the long 1 onto the stack
            codeTable.Add("fconst_0", new JOpCode("fconst_0", "0b", "0"));//push 0.0f on the stack
            codeTable.Add("fconst_1", new JOpCode("fconst_1", "0c", "0"));//push 1.0f on the stack
            codeTable.Add("fconst_2", new JOpCode("fconst_2", "0d", "0"));//push 2.0f on the stack
            codeTable.Add("dconst_0", new JOpCode("dconst_0", "0e", "0"));//push the constant 0.0 onto the stack
            codeTable.Add("dconst_1", new JOpCode("dconst_1", "0f", "0"));//push the constant 1.0 onto the stack
            codeTable.Add("bipush", new JOpCode("bipush", "10", "1"));//push a byte onto the stack as an integer value
            codeTable.Add("sipush", new JOpCode("sipush", "11", "2"));//push a short onto the stack
            codeTable.Add("ldc", new JOpCode("ldc", "12", "1"));//push a constant #index from a constant pool (String, int or float) onto the stack
            codeTable.Add("ldc_w", new JOpCode("ldc_w", "13", "2"));//push a constant #index from a constant pool (String, int or float) onto the stack (wide index is constructed as indexbyte1 << 8 + indexbyte2)
            codeTable.Add("ldc2_w", new JOpCode("ldc2_w", "14", "2"));//push a constant #index from a constant pool (double or long) onto the stack (wide index is constructed as indexbyte1 << 8 + indexbyte2)
            codeTable.Add("iload", new JOpCode("iload", "15", "1"));//load an int value from a local variable #index
            codeTable.Add("lload", new JOpCode("lload", "16", "1"));//load a long value from a local variable #index
            codeTable.Add("fload", new JOpCode("fload", "17", "1"));//load a float value from a local variable #index
            codeTable.Add("dload", new JOpCode("dload", "18", "1"));//load a double value from a local variable #index
            codeTable.Add("aload", new JOpCode("aload", "19", "1"));//load a reference onto the stack from a local variable #index
            codeTable.Add("iload_0", new JOpCode("iload_0", "1a", "0"));//load an int value from local variable 0
            codeTable.Add("iload_1", new JOpCode("iload_1", "1b", "0"));//load an int value from local variable 1
            codeTable.Add("iload_2", new JOpCode("iload_2", "1c", "0"));//load an int value from local variable 2
            codeTable.Add("iload_3", new JOpCode("iload_3", "1d", "0"));//load an int value from local variable 3
            codeTable.Add("lload_0", new JOpCode("lload_0", "1e", "0"));//load a long value from a local variable 0
            codeTable.Add("lload_1", new JOpCode("lload_1", "1f", "0"));//load a long value from a local variable 1
            codeTable.Add("lload_2", new JOpCode("lload_2", "20", "0"));//load a long value from a local variable 2
            codeTable.Add("lload_3", new JOpCode("lload_3", "21", "0"));//load a long value from a local variable 3
            codeTable.Add("fload_0", new JOpCode("fload_0", "22", "0"));//load a float value from local variable 0
            codeTable.Add("fload_1", new JOpCode("fload_1", "23", "0"));//load a float value from local variable 1
            codeTable.Add("fload_2", new JOpCode("fload_2", "24", "0"));//load a float value from local variable 2
            codeTable.Add("fload_3", new JOpCode("fload_3", "25", "0"));//load a float value from local variable 3
            codeTable.Add("dload_0", new JOpCode("dload_0", "26", "0"));//load a double from local variable 0
            codeTable.Add("dload_1", new JOpCode("dload_1", "27", "0"));//load a double from local variable 1
            codeTable.Add("dload_2", new JOpCode("dload_2", "28", "0"));//load a double from local variable 2
            codeTable.Add("dload_3", new JOpCode("dload_3", "29", "0"));//load a double from local variable 3
            codeTable.Add("aload_0", new JOpCode("aload_0", "2a", "0"));//load a reference onto the stack from local variable 0
            codeTable.Add("aload_1", new JOpCode("aload_1", "2b", "0"));//load a reference onto the stack from local variable 1
            codeTable.Add("aload_2", new JOpCode("aload_2", "2c", "0"));//load a reference onto the stack from local variable 2
            codeTable.Add("aload_3", new JOpCode("aload_3", "2d", "0"));//load a reference onto the stack from local variable 3
            codeTable.Add("iaload", new JOpCode("iaload", "2e", "0"));//load an int from an array
            codeTable.Add("laload", new JOpCode("laload", "2f", "0"));//load a long from an array
            codeTable.Add("faload", new JOpCode("faload", "30", "0"));//load a float from an array
            codeTable.Add("daload", new JOpCode("daload", "31", "0"));//load a double from an array
            codeTable.Add("aaload", new JOpCode("aaload", "32", "0"));//load onto the stack a reference from an array
            codeTable.Add("baload", new JOpCode("baload", "33", "0"));//load a byte or Boolean value from an array
            codeTable.Add("caload", new JOpCode("caload", "34", "0"));//load a char from an array
            codeTable.Add("saload", new JOpCode("saload", "35", "0"));//load short from array
            codeTable.Add("istore", new JOpCode("istore", "36", "1"));//store int value into variable #index
            codeTable.Add("lstore", new JOpCode("lstore", "37", "1"));//store a long value in a local variable #index
            codeTable.Add("fstore", new JOpCode("fstore", "38", "1"));//store a float value into a local variable #index
            codeTable.Add("dstore", new JOpCode("dstore", "39", "1"));//store a double value into a local variable #index
            codeTable.Add("astore", new JOpCode("astore", "3a", "1"));//store a reference into a local variable #index
            codeTable.Add("istore_0", new JOpCode("istore_0", "3b", "0"));//store int value into variable 0
            codeTable.Add("istore_1", new JOpCode("istore_1", "3c", "0"));//store int value into variable 1
            codeTable.Add("istore_2", new JOpCode("istore_2", "3d", "0"));//store int value into variable 2
            codeTable.Add("istore_3", new JOpCode("istore_3", "3e", "0"));//store int value into variable 3
            codeTable.Add("lstore_0", new JOpCode("lstore_0", "3f", "0"));//store a long value in a local variable 0
            codeTable.Add("lstore_1", new JOpCode("lstore_1", "40", "0"));//store a long value in a local variable 1
            codeTable.Add("lstore_2", new JOpCode("lstore_2", "41", "0"));//store a long value in a local variable 2
            codeTable.Add("lstore_3", new JOpCode("lstore_3", "42", "0"));//store a long value in a local variable 3
            codeTable.Add("fstore_0", new JOpCode("fstore_0", "43", "0"));//store a float value into local variable 0
            codeTable.Add("fstore_1", new JOpCode("fstore_1", "44", "0"));//store a float value into local variable 1
            codeTable.Add("fstore_2", new JOpCode("fstore_2", "45", "0"));//store a float value into local variable 2
            codeTable.Add("fstore_3", new JOpCode("fstore_3", "46", "0"));//store a float value into local variable 3
            codeTable.Add("dstore_0", new JOpCode("dstore_0", "47", "0"));//store a double into local variable 0
            codeTable.Add("dstore_1", new JOpCode("dstore_1", "48", "0"));//store a double into local variable 1
            codeTable.Add("dstore_2", new JOpCode("dstore_2", "49", "0"));//store a double into local variable 2
            codeTable.Add("dstore_3", new JOpCode("dstore_3", "4a", "0"));//store a double into local variable 3
            codeTable.Add("astore_0", new JOpCode("astore_0", "4b", "0"));//store a reference into local variable 0
            codeTable.Add("astore_1", new JOpCode("astore_1", "4c", "0"));//store a reference into local variable 1
            codeTable.Add("astore_2", new JOpCode("astore_2", "4d", "0"));//store a reference into local variable 2
            codeTable.Add("astore_3", new JOpCode("astore_3", "4e", "0"));//store a reference into local variable 3
            codeTable.Add("iastore", new JOpCode("iastore", "4f", "0"));//store an int into an array
            codeTable.Add("lastore", new JOpCode("lastore", "50", "0"));//store a long to an array
            codeTable.Add("fastore", new JOpCode("fastore", "51", "0"));//store a float in an array
            codeTable.Add("dastore", new JOpCode("dastore", "52", "0"));//store a double into an array
            codeTable.Add("aastore", new JOpCode("aastore", "53", "0"));//store into a reference in an array
            codeTable.Add("bastore", new JOpCode("bastore", "54", "0"));//store a byte or Boolean value into an array
            codeTable.Add("castore", new JOpCode("castore", "55", "0"));//store a char into an array
            codeTable.Add("sastore", new JOpCode("sastore", "56", "0"));//store short to array
            codeTable.Add("pop", new JOpCode("pop", "57", "0"));//discard the top value on the stack
            codeTable.Add("pop2", new JOpCode("pop2", "58", "0"));//discard the top two values on the stack (or one value, if it is a double or long)
            codeTable.Add("dup", new JOpCode("dup", "59", "0"));//duplicate the value on top of the stack
            codeTable.Add("dup_x1", new JOpCode("dup_x1", "5a", "0"));//insert a copy of the top value into the stack two values from the top. value1 and value2 must not be of the type double or long.
            codeTable.Add("dup_x2", new JOpCode("dup_x2", "5b", "0"));//insert a copy of the top value into the stack two (if value2 is double or long it takes up the entry of value3, too) or three values (if value2 is neither double nor long) from the top
            codeTable.Add("dup2", new JOpCode("dup2", "5c", "0"));//duplicate top two stack words (two values, if value1 is not double nor long; a single value, if value1 is double or long)
            codeTable.Add("dup2_x1", new JOpCode("dup2_x1", "5d", "0"));//duplicate two words and insert beneath third word (see explanation above)
            codeTable.Add("dup2_x2", new JOpCode("dup2_x2", "5e", "0"));//duplicate two words and insert beneath fourth word
            codeTable.Add("swap", new JOpCode("swap", "5f", "0"));//swaps two top words on the stack (note that value1 and value2 must not be double or long)
            codeTable.Add("iadd", new JOpCode("iadd", "60", "0"));//add two ints
            codeTable.Add("ladd", new JOpCode("ladd", "61", "0"));//add two longs
            codeTable.Add("fadd", new JOpCode("fadd", "62", "0"));//add two floats
            codeTable.Add("dadd", new JOpCode("dadd", "63", "0"));//add two doubles
            codeTable.Add("isub", new JOpCode("isub", "64", "0"));//int subtract
            codeTable.Add("lsub", new JOpCode("lsub", "65", "0"));//subtract two longs
            codeTable.Add("fsub", new JOpCode("fsub", "66", "0"));//subtract two floats
            codeTable.Add("dsub", new JOpCode("dsub", "67", "0"));//subtract a double from another
            codeTable.Add("imul", new JOpCode("imul", "68", "0"));//multiply two integers
            codeTable.Add("lmul", new JOpCode("lmul", "69", "0"));//multiply two longs
            codeTable.Add("fmul", new JOpCode("fmul", "6a", "0"));//multiply two floats
            codeTable.Add("dmul", new JOpCode("dmul", "6b", "0"));//multiply two doubles
            codeTable.Add("idiv", new JOpCode("idiv", "6c", "0"));//divide two integers
            codeTable.Add("ldiv", new JOpCode("ldiv", "6d", "0"));//divide two longs
            codeTable.Add("fdiv", new JOpCode("fdiv", "6e", "0"));//divide two floats
            codeTable.Add("ddiv", new JOpCode("ddiv", "6f", "0"));//divide two doubles
            codeTable.Add("irem", new JOpCode("irem", "70", "0"));//logical int remainder
            codeTable.Add("lrem", new JOpCode("lrem", "71", "0"));//remainder of division of two longs
            codeTable.Add("frem", new JOpCode("frem", "72", "0"));//get the remainder from a division between two floats
            codeTable.Add("drem", new JOpCode("drem", "73", "0"));//get the remainder from a division between two doubles
            codeTable.Add("ineg", new JOpCode("ineg", "74", "0"));//negate int
            codeTable.Add("lneg", new JOpCode("lneg", "75", "0"));//negate a long
            codeTable.Add("fneg", new JOpCode("fneg", "76", "0"));//negate a float
            codeTable.Add("dneg", new JOpCode("dneg", "77", "0"));//negate a double
            codeTable.Add("ishl", new JOpCode("ishl", "78", "0"));//int shift left
            codeTable.Add("lshl", new JOpCode("lshl", "79", "0"));//bitwise shift left of a long value1 by int value2 positions
            codeTable.Add("ishr", new JOpCode("ishr", "7a", "0"));//int arithmetic shift right
            codeTable.Add("lshr", new JOpCode("lshr", "7b", "0"));//bitwise shift right of a long value1 by int value2 positions
            codeTable.Add("iushr", new JOpCode("iushr", "7c", "0"));//int logical shift right
            codeTable.Add("lushr", new JOpCode("lushr", "7d", "0"));//bitwise shift right of a long value1 by int value2 positions, unsigned
            codeTable.Add("iand", new JOpCode("iand", "7e", "0"));//perform a bitwise and on two integers
            codeTable.Add("land", new JOpCode("land", "7f", "0"));//bitwise and of two longs
            codeTable.Add("ior", new JOpCode("ior", "80", "0"));//bitwise int or
            codeTable.Add("lor", new JOpCode("lor", "81", "0"));//bitwise or of two longs
            codeTable.Add("ixor", new JOpCode("ixor", "82", "0"));//int xor
            codeTable.Add("lxor", new JOpCode("lxor", "83", "0"));//bitwise exclusive or of two longs
            codeTable.Add("iinc", new JOpCode("iinc", "84", "2"));//increment local variable #index by signed byte const
            codeTable.Add("i2l", new JOpCode("i2l", "85", "0"));//convert an int into a long
            codeTable.Add("i2f", new JOpCode("i2f", "86", "0"));//convert an int into a float
            codeTable.Add("i2d", new JOpCode("i2d", "87", "0"));//convert an int into a double
            codeTable.Add("l2i", new JOpCode("l2i", "88", "0"));//convert a long to a int
            codeTable.Add("l2f", new JOpCode("l2f", "89", "0"));//convert a long to a float
            codeTable.Add("l2d", new JOpCode("l2d", "8a", "0"));//convert a long to a double
            codeTable.Add("f2i", new JOpCode("f2i", "8b", "0"));//convert a float to an int
            codeTable.Add("f2l", new JOpCode("f2l", "8c", "0"));//convert a float to a long
            codeTable.Add("f2d", new JOpCode("f2d", "8d", "0"));//convert a float to a double
            codeTable.Add("d2i", new JOpCode("d2i", "8e", "0"));//convert a double to an int
            codeTable.Add("d2l", new JOpCode("d2l", "8f", "0"));//convert a double to a long
            codeTable.Add("d2f", new JOpCode("d2f", "90", "0"));//convert a double to a float
            codeTable.Add("i2b", new JOpCode("i2b", "91", "0"));//convert an int into a byte
            codeTable.Add("i2c", new JOpCode("i2c", "92", "0"));//convert an int into a character
            codeTable.Add("i2s", new JOpCode("i2s", "93", "0"));//convert an int into a short
            codeTable.Add("lcmp", new JOpCode("lcmp", "94", "0"));//compare two longs values
            codeTable.Add("fcmpl", new JOpCode("fcmpl", "95", "0"));//compare two floats
            codeTable.Add("fcmpg", new JOpCode("fcmpg", "96", "0"));//compare two floats
            codeTable.Add("dcmpl", new JOpCode("dcmpl", "97", "0"));//compare two doubles
            codeTable.Add("dcmpg", new JOpCode("dcmpg", "98", "0"));//compare two doubles
            codeTable.Add("ifeq", new JOpCode("ifeq", "99", "2"));//if value is 0, branch to instruction at branchoffset (signed short constructed from unsigned bytes branchbyte1 << 8 + branchbyte2)
            codeTable.Add("ifne", new JOpCode("ifne", "9a", "2"));//if value is not 0, branch to instruction at branchoffset (signed short constructed from unsigned bytes branchbyte1 << 8 + branchbyte2)
            codeTable.Add("iflt", new JOpCode("iflt", "9b", "2"));//if value is less than 0, branch to instruction at branchoffset (signed short constructed from unsigned bytes branchbyte1 << 8 + branchbyte2)
            codeTable.Add("ifge", new JOpCode("ifge", "9c", "2"));//if value is greater than or equal to 0, branch to instruction at branchoffset (signed short constructed from unsigned bytes branchbyte1 << 8 + branchbyte2)
            codeTable.Add("ifgt", new JOpCode("ifgt", "9d", "2"));//if value is greater than 0, branch to instruction at branchoffset (signed short constructed from unsigned bytes branchbyte1 << 8 + branchbyte2)
            codeTable.Add("ifle", new JOpCode("ifle", "9e", "2"));//if value is less than or equal to 0, branch to instruction at branchoffset (signed short constructed from unsigned bytes branchbyte1 << 8 + branchbyte2)
            codeTable.Add("if_icmpeq", new JOpCode("if_icmpeq", "9f", "2"));//if ints are equal, branch to instruction at branchoffset (signed short constructed from unsigned bytes branchbyte1 << 8 + branchbyte2)
            codeTable.Add("if_icmpne", new JOpCode("if_icmpne", "a0", "2"));//if ints are not equal, branch to instruction at branchoffset (signed short constructed from unsigned bytes branchbyte1 << 8 + branchbyte2)
            codeTable.Add("if_icmplt", new JOpCode("if_icmplt", "a1", "2"));//if value1 is less than value2, branch to instruction at branchoffset (signed short constructed from unsigned bytes branchbyte1 << 8 + branchbyte2)
            codeTable.Add("if_icmpge", new JOpCode("if_icmpge", "a2", "2"));//if value1 is greater than or equal to value2, branch to instruction at branchoffset (signed short constructed from unsigned bytes branchbyte1 << 8 + branchbyte2)
            codeTable.Add("if_icmpgt", new JOpCode("if_icmpgt", "a3", "2"));//if value1 is greater than value2, branch to instruction at branchoffset (signed short constructed from unsigned bytes branchbyte1 << 8 + branchbyte2)
            codeTable.Add("if_icmple", new JOpCode("if_icmple", "a4", "2"));//if value1 is less than or equal to value2, branch to instruction at branchoffset (signed short constructed from unsigned bytes branchbyte1 << 8 + branchbyte2)
            codeTable.Add("if_acmpeq", new JOpCode("if_acmpeq", "a5", "2"));//if references are equal, branch to instruction at branchoffset (signed short constructed from unsigned bytes branchbyte1 << 8 + branchbyte2)
            codeTable.Add("if_acmpne", new JOpCode("if_acmpne", "a6", "2"));//if references are not equal, branch to instruction at branchoffset (signed short constructed from unsigned bytes branchbyte1 << 8 + branchbyte2)
            codeTable.Add("goto", new JOpCode("goto", "a7", "2"));//goes to another instruction at branchoffset (signed short constructed from unsigned bytes branchbyte1 << 8 + branchbyte2)
            codeTable.Add("jsr", new JOpCode("jsr", "a8", "2"));//jump to subroutine at branchoffset (signed short constructed from unsigned bytes branchbyte1 << 8 + branchbyte2) and place the return address on the stack
            codeTable.Add("ret", new JOpCode("ret", "a9", "1"));//continue execution from address taken from a local variable #index (the asymmetry with jsr is intentional)
            //codeTable.Add("tableswitch",	new JOpCode("tableswitch", "aa", "0"));//continue execution from an address in the table at offset index
            //codeTable.Add("lookupswitch",	new JOpCode("lookupswitch", "ab", "0"));//a target address is looked up from a table using a key and execution continues from the instruction at that address
            codeTable.Add("ireturn", new JOpCode("ireturn", "ac", "0"));//return an integer from a method
            codeTable.Add("lreturn", new JOpCode("lreturn", "ad", "0"));//return a long value
            codeTable.Add("freturn", new JOpCode("freturn", "ae", "0"));//return a float
            codeTable.Add("dreturn", new JOpCode("dreturn", "af", "0"));//return a double from a method
            codeTable.Add("areturn", new JOpCode("areturn", "b0", "0"));//return a reference from a method
            codeTable.Add("return", new JOpCode("return", "b1", "0"));//return void from method
            codeTable.Add("getstatic", new JOpCode("getstatic", "b2", "2"));//get a static field value of a class, where the field is identified by field reference in the constant pool index (index1 << 8 + index2)
            codeTable.Add("putstatic", new JOpCode("putstatic", "b3", "2"));//set static field to value in a class, where the field is identified by a field reference index in constant pool (indexbyte1 << 8 + indexbyte2)
            codeTable.Add("getfield", new JOpCode("getfield", "b4", "2"));//get a field value of an object objectref, where the field is identified by field reference in the constant pool index (index1 << 8 + index2)
            codeTable.Add("putfield", new JOpCode("putfield", "b5", "2"));//set field to value in an object objectref, where the field is identified by a field reference index in constant pool (indexbyte1 << 8 + indexbyte2)
            codeTable.Add("invokevirtual", new JOpCode("invokevirtual", "b6", "2"));//invoke virtual method on object objectref and puts the result on the stack (might be void); the method is identified by method reference index in constant pool (indexbyte1 << 8 + indexbyte2)
            codeTable.Add("invokespecial", new JOpCode("invokespecial", "b7", "2"));//invoke instance method on object objectref and puts the result on the stack (might be void); the method is identified by method reference index in constant pool (indexbyte1 << 8 + indexbyte2)
            codeTable.Add("invokestatic", new JOpCode("invokestatic", "b8", "2"));//invoke a static method and puts the result on the stack (might be void); the method is identified by method reference index in constant pool (indexbyte1 << 8 + indexbyte2)
            codeTable.Add("invokeinterface", new JOpCode("invokeinterface", "b9", "4"));//invokes an interface method on object objectref and puts the result on the stack (might be void); the interface method is identified by method reference index in constant pool (indexbyte1 << 8 + indexbyte2)
            codeTable.Add("invokedynamic", new JOpCode("invokedynamic", "ba", "4"));//invokes a dynamic method and puts the result on the stack (might be void); the method is identified by method reference index in constant pool (indexbyte1 << 8 + indexbyte2)
            codeTable.Add("new", new JOpCode("new", "bb", "2"));//create new object of type identified by class reference in constant pool index (indexbyte1 << 8 + indexbyte2)
            codeTable.Add("newarray", new JOpCode("newarray", "bc", "1"));//create new array with count elements of primitive type identified by atype
            codeTable.Add("anewarray", new JOpCode("anewarray", "bd", "2"));//create a new array of references of length count and component type identified by the class reference index (indexbyte1 << 8 + indexbyte2) in the constant pool
            codeTable.Add("arraylength", new JOpCode("arraylength", "be", "0"));//get the length of an array
            codeTable.Add("athrow", new JOpCode("athrow", "bf", "0"));//throws an error or exception (notice that the rest of the stack is cleared, leaving only a reference to the Throwable)
            codeTable.Add("checkcast", new JOpCode("checkcast", "c0", "2"));//checks whether an objectref is of a certain type, the class reference of which is in the constant pool at index (indexbyte1 << 8 + indexbyte2)
            codeTable.Add("instanceof", new JOpCode("instanceof", "c1", "2"));//determines if an object objectref is of a given type, identified by class reference index in constant pool (indexbyte1 << 8 + indexbyte2)
            codeTable.Add("monitorenter", new JOpCode("monitorenter", "c2", "0"));//enter monitor for object ("grab the lock" – start of synchronized() section)
            codeTable.Add("monitorexit", new JOpCode("monitorexit", "c3", "0"));//exit monitor for object ("release the lock" – end of synchronized() section)
            //codeTable.Add("wide",	new JOpCode("wide", "c4", "0"));//execute opcode, where opcode is either iload, fload, aload, lload, dload, istore, fstore, astore, lstore, dstore, or ret, but assume the index is 16 bit; or execute iinc, where the index is 16 bits and the constant to increment by is a signed 16 bit short
            codeTable.Add("multianewarray", new JOpCode("multianewarray", "c5", "3"));//create a new array of dimensions dimensions with elements of type identified by class reference in constant pool index (indexbyte1 << 8 + indexbyte2); the sizes of each dimension is identified by count1, [count2, etc.]
            codeTable.Add("ifnull", new JOpCode("ifnull", "c6", "2"));//if value is null, branch to instruction at branchoffset (signed short constructed from unsigned bytes branchbyte1 << 8 + branchbyte2)
            codeTable.Add("ifnonnull", new JOpCode("ifnonnull", "c7", "2"));//if value is not null, branch to instruction at branchoffset (signed short constructed from unsigned bytes branchbyte1 << 8 + branchbyte2)
            codeTable.Add("goto_w", new JOpCode("goto_w", "c8", "4"));//goes to another instruction at branchoffset (signed int constructed from unsigned bytes branchbyte1 << 24 + branchbyte2 << 16 + branchbyte3 << 8 + branchbyte4)
            codeTable.Add("jsr_w", new JOpCode("jsr_w", "c9", "4"));//jump to subroutine at branchoffset (signed int constructed from unsigned bytes branchbyte1 << 24 + branchbyte2 << 16 + branchbyte3 << 8 + branchbyte4) and place the return address on the stack
            codeTable.Add("breakpoint", new JOpCode("breakpoint", "ca", "0"));//reserved for breakpoints in Java debuggers; should not appear in any class file
            codeTable.Add("(no name)", new JOpCode("(no name)", "cb fd", "0"));//these values are currently unassigned for opcodes and are reserved for future use
            codeTable.Add("impdep1", new JOpCode("impdep1", "fe", "0"));//reserved for implementation-dependent operations within debuggers; should not appear in any class file
            codeTable.Add("impdep2", new JOpCode("impdep2", "ff", "0"));//reserved for implementation-dependent operations within debuggers; should not appear in any class file


        }
        #endregion

        #region process ILDASM data

        //remove the newline after commas
        private void PREprocessILDASM()
        {
            string data = string.Empty;
            string temp=string.Empty;
            for (int i = 0; i < tb_data.Lines.Length; i++)
            {
                temp = tb_data.Lines[i].Trim();
                
                if (temp == string.Empty) continue;
                if (temp[temp.Length-1]==',')
                {

                    data += temp;
                    continue;
                }
                else
                {
                    data += temp + Environment.NewLine;
                }
            }
            tb_data.Text = data;
            data = null;

        }
        private void processJBE(bool keepMetaData=true)
        {
            StringBuilder data = new StringBuilder();
            string wildcard = " ??";
            bool error = false;


            //return if blank
            if (string.IsNullOrWhiteSpace(tb_data.Text)) { return; }
            
            
            foreach (string line in tb_data.Lines)
            {
                if(string.IsNullOrWhiteSpace(line)){continue;}

                try
                {
                    string mnemonic = Regex.Match(line.Trim(), @"^\s*(\w+)").Groups[1].Value;
                    if (codeTable.Contains(mnemonic))
                    {
                        JOpCode jOp = (JOpCode)codeTable[mnemonic];
                        data.AppendFormat("//{0}", jOp.OpCode);
                        for (int i = 0; i < jOp.OperandCount; i++)
                        {
                            data.Append(wildcard);
                        }
                        data.Append(Environment.NewLine);
                        data.AppendLine(line.Trim().Replace('/', '.'));
                    }
                    else
                    {
                        //mnemonic not found, throw error and quit
                        MessageBox.Show("unable to recognize the mnemonic \""+mnemonic+"\"."
                            +Environment.NewLine+"Parser will now exit.",
                            "error", MessageBoxButtons.OK
                            );
                        error = true;
                        break;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "error",MessageBoxButtons.OK);
                    error = true;
                    break;
                }
            }

            if (!error)
            {
                if (cb_autoclose.Checked == true)
                {
                    //copy data to main form and close conversion window
                    if (parentForm != null)
                    {
                        ((Form1)parentForm).tb_ByteCodeInput.Text = data.ToString();
                        this.Close();
                    }
                }
                else
                {
                    //set the tb_data text to data
                    tb_data.Text = data.ToString();
                }
            }
            
        }

        private void processILDASMWithBranchResolution(bool keepMetaData = true)
        {
            processJBE(keepMetaData);
        }//end process ildasm with branch resolution

        private void GetInstructionLengths(ref List<int> il)
        {
            //-------------group 1 is OPERATION NUMBER, group 2 is the proper bytes, group 3 is the instruction name
            string ptrn = @"L_([a-fA-F\d]{4}):(\s+/\*.+\*/)*\s+([\w\d\.]+)\s*(.*)";
            Match m;//,m2;
            foreach (string line in tb_data.Lines)
            {
                if (Regex.IsMatch(line, ptrn))
                {
                    m = Regex.Match(line, ptrn);
                    il.Add( Convert.ToInt32(m.Groups[1].Value, 16));
                }                
            }//end forloop
        }
        #endregion

        #region buttons n such
        private void button1_Click(object sender, EventArgs e)
        {
            if (cb_resolveBranches.Checked)
            {
                processILDASMWithBranchResolution(cb_metadata.Checked);
            }
            else
            {
                processJBE(cb_metadata.Checked);
            }
            
        }

        private void tb_data_DoubleClick(object sender, EventArgs e)
        {
            tb_data.SelectAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (parentForm != null)
            {
                ((Form1)parentForm).tb_ByteCodeInput.Text = tb_data.Text;
            }
        }

        private void btn_sample_Click(object sender, EventArgs e)
        {
            tb_data.Text = @"bipush 18
if_icmpne 42
aload_0
aload_2
iload_3
invokevirtual org/gjt/jclasslib/structures/ClassFile/getConstantPoolEntry(I)Lorg/gjt/jclasslib/structures/CPInfo;
invokevirtual org/gjt/jclasslib/structures/CPInfo/getTagVerbose()Ljava/lang/String;
invokespecial ee/ioc/cs/jbe/browser/codeedit/CodeGenerator/getConstType(Ljava/lang/String;)Ljava/lang/String;
ldc ""S""
invokevirtual java/lang/String/equals(Ljava/lang/Object;)Z
ifeq 33
new java/lang/StringBuilder
dup
ldc """"""
invokespecial java/lang/StringBuilder/<init>(Ljava/lang/String;)V
aload_2
iload_3
invokevirtual org/gjt/jclasslib/structures/ClassFile/getConstantPoolEntryName(I)Ljava/lang/String;
invokevirtual java/lang/StringBuilder/append(Ljava/lang/String;)Ljava/lang/StringBuilder;";
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                tb_data.Text = Clipboard.GetText();
            }
            catch (Exception err)
            {
                System.Diagnostics.Debug.WriteLine(err.Message);
            }
        }
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tb_data.Focus();
            tb_data.SelectAll();
        }
        #endregion

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            getCodesFromWiki();
        }

        private void UnityConverter_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("saving settings");
            Properties.Settings.Default.unity_resolveBranches = cb_resolveBranches.Checked;
            Properties.Settings.Default.unity_keepMetadata = cb_metadata.Checked;
            Properties.Settings.Default.unity_autoclose = cb_autoclose.Checked;
            Properties.Settings.Default.Save();

        }

     
        

        
    }
}
