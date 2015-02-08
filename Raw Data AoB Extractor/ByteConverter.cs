using System;

namespace Raw_Data_AoB_Extractor
{
    class ByteConverter:System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        private int _4byte = 0;
        private int _4byteX8 = 0;
        private int _4byteX8P6 = 0;
        private int _hex = 0;
        private int _u30 = 0;
        private Single _ieee754x32 = 0;
        private double _ieee754x64 = 0;


        public string U30
        {
            get
            {
                return _u30.ToString("X"); 
                //byte[] b = BitConverter.GetBytes(_u30);
                //return string.Format("{0:X2} {1:X2} {2:X2} {3:X2}", b[3], b[2], b[1], b[0]);
            }
            set {
                _u30 = HandleHexInput(value);                
                _4byte = convertU30ToInt(_u30);
                _4byteX8 = _4byte * 8;
                _4byteX8P6 = _4byte * 8 + 6;
                _hex = _4byte;
                _ieee754x32 = Convert.ToSingle(_4byte);
                _ieee754x64 = Convert.ToDouble(_4byte);

                OnPropertyChanged("U30");
            }
        }
        

        public string Hex
        {
            get { return _hex.ToString("X"); }
            set { 
                _hex = HandleHexInput(value);
                _4byte = _hex;
                _4byteX8 = _4byte * 8;
                _4byteX8P6 = _4byte * 8 + 6;                
                _u30 = convertIntToU30();
                _ieee754x32 = System.Convert.ToSingle(_4byte);
                _ieee754x64 = Convert.ToDouble(_4byte);
                OnPropertyChanged("Hex");
            }
        }
        

        public int four_byte_X8_P6
        {
            get { return _4byteX8P6; }
            set {
                _4byteX8P6 = value;
                _4byte = (int)(((_4byteX8P6 - 6)) / 8.0);
                _4byteX8 = (int)(_4byte * 8);
                _hex = _4byte;
                _u30 = convertIntToU30();
                _ieee754x32 = Convert.ToSingle(_4byte);
                _ieee754x64 = Convert.ToDouble(_4byte);
                OnPropertyChanged("_4byte_X8_P6");
            }
        }
        
        public int four_byte_X8
        {
            get { return _4byteX8; }
            set { 
                _4byteX8 = value;
                _4byte = (int)(_4byteX8 / 8.0);                
                _4byteX8P6 = _4byte * 8 + 6;
                _hex = _4byte;
                _u30 = convertIntToU30();
                _ieee754x32 = Convert.ToSingle(_4byte);
                _ieee754x64 = Convert.ToDouble(_4byte);

                OnPropertyChanged("_4byteX8");
            }
        }
        
        public int four_byte
        {
            get { return _4byte; }
            set { 
                _4byte = value;
                _4byteX8 = _4byte * 8;
                _4byteX8P6 = _4byte * 8 + 6;
                _hex = _4byte;                
                _u30 = convertIntToU30();
                _ieee754x32 = Convert.ToSingle(_4byte);
                _ieee754x64 = Convert.ToDouble(_4byte);
                OnPropertyChanged("_4byte");

            }
        }

        public string ieee754x32
        {
            get 
            { 
                //return BitConverter.ToString(BitConverter.GetBytes(_ieee754x32)).Replace("-", " "); 
                byte[] b = BitConverter.GetBytes(_ieee754x32);
                return string.Format("{0:X2}{1:X2}{2:X2}{3:X2}",b[3],b[2],b[1],b[0]);
            }
            set
            {
                try
                {
                    System.Diagnostics.Debug.WriteLine("SET CALLED");
                    _ieee754x32 = HandleIEEE754x32Input(value);
                    _4byte = Convert.ToInt32(_ieee754x32);
                    _ieee754x64 = Convert.ToDouble(_4byte);
                    _hex = _4byte;
                    _4byteX8 = _4byte * 8;
                    _4byteX8P6 = _4byte * 8 + 6;
                    _u30 = convertIntToU30();
                    OnPropertyChanged("ieee754x32");
                }
                catch (Exception err)
                {
                    System.Windows.Forms.MessageBox.Show(err.Message, "Critical Error");
                }
            }
        }
        public string ieee754x64
        {
            get
            {
                //return BitConverter.ToString(BitConverter.GetBytes(_ieee754x32)).Replace("-", " "); 
                byte[] b = BitConverter.GetBytes(_ieee754x64);
                return string.Format("{0:X2}{1:X2}{2:X2}{3:X2}{4:X2}{5:X2}{6:X2}{7:X2}", b[7], b[6], b[5], b[4], b[3], b[2], b[1], b[0]);
            }
            set
            {
                System.Diagnostics.Debug.WriteLine("SET CALLED");
                _ieee754x64 = HandleIEEE754x64Input(value);
                try
                {
                    _4byte = Convert.ToInt32(_ieee754x32);
                    _ieee754x64 = Convert.ToDouble(_4byte);
                    _hex = _4byte;
                    _4byteX8 = _4byte * 8;
                    _4byteX8P6 = _4byte * 8 + 6;
                    _u30 = convertIntToU30();
                    OnPropertyChanged("ieee754x32");
                }
                catch (Exception err)
                {
                    System.Windows.Forms.MessageBox.Show(err.Message, "Critical Error");
                }
            }
        }
        public string unityIeee754x32
        {
            get
            { 
                return BitConverter.ToString(BitConverter.GetBytes(_ieee754x32)).Replace("-", " ");                 
            }
            set
            {
                System.Diagnostics.Debug.WriteLine("SET CALLED");
                _ieee754x32 = HandleIEEE754x32Input(value);
                _4byte = Convert.ToInt32(_ieee754x32);
                _hex = _4byte;
                _4byteX8 = _4byte * 8;
                _4byteX8P6 = _4byte * 8 + 6;
                _u30 = convertIntToU30();
                OnPropertyChanged("ieee754x32");
            }
        }
        private Single HandleIEEE754x32Input(string val)
        {
            val = val.Replace(" ", string.Empty);
            if (System.Text.RegularExpressions.Regex.IsMatch(val, @"^[\da-fA-F]+$"))
            {
                try
                {
                    return BitConverter.ToSingle(BitConverter.GetBytes(Convert.ToInt32(val, 16)),0);
                    //System.Diagnostics.Debug.WriteLine((int)(val.Length / 2));
                    //byte[] raw = new byte[val.Length / 2];
                    //for (int i = 0; i < raw.Length; i++)
                    //{
                    //    // THEN DEPENDING ON ENDIANNESS
                    //    raw[i] = Convert.ToByte(val.Substring(i * 2, 2), 16);
                    //    // OR
                    //    //raw[raw.Length - i - 1] = Convert.ToByte(val.Substring(i * 2, 2), 16);
                    //}
                    //return BitConverter.ToSingle(raw, 0);
                  
                }
                catch
                {
                    return 0;
                }
            }
            else
                return 0;
        }
        private double HandleIEEE754x64Input(string val)
        {
            val = val.Replace(" ", string.Empty);
            if (System.Text.RegularExpressions.Regex.IsMatch(val, @"^[\da-fA-F]+$"))
            {
                try
                {
                    return BitConverter.ToDouble(BitConverter.GetBytes(Convert.ToInt64(val, 16)), 0);
                    //System.Diagnostics.Debug.WriteLine((int)(val.Length / 2));
                    //byte[] raw = new byte[val.Length / 2];
                    //for (int i = 0; i < raw.Length; i++)
                    //{
                    //    // THEN DEPENDING ON ENDIANNESS
                    //    raw[i] = Convert.ToByte(val.Substring(i * 2, 2), 16);
                    //    // OR
                    //    //raw[raw.Length - i - 1] = Convert.ToByte(val.Substring(i * 2, 2), 16);
                    //}
                    //return BitConverter.ToSingle(raw, 0);

                }
                catch
                {
                    return 0;
                }
            }
            else
                return 0;
        }
        private int HandleHexInput(string val)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(val, @"^[\da-fA-F]+$"))
            {
                try
                {
                    return System.Convert.ToInt32(val, 16);
                }
                catch
                {
                    return 0;
                }
            }
            else
                return 0;
        }

        private int convertU30ToInt(int val)
        {
            try
            {
                
                string bin = System.Convert.ToString(val, 2);
                string swappedbin = string.Empty;

                while (bin.Length > 0)
                {
                    if (bin.Length > 8)
                    {
                        swappedbin = bin.Substring(1,7)+swappedbin;
                        bin = bin.Substring(8);
                    }
                    else
                    {
                        while (bin.Length < 8)
                            bin ="0" + bin;
                        swappedbin = bin + swappedbin;
                        bin = "";
                    }
                }

                return System.Convert.ToInt32(swappedbin, 2);

            }
            catch(System.Exception err)
            {
                System.Diagnostics.Debug.WriteLine("error" + err.Message);
                return _u30;
            }           
            
        }//end u30 to int
        private int convertIntToU30()
        {
            if (_4byte < 1)
                return 0;
            //string bin = int.Parse(textBox1.Text).ToString("2");
            string bin = (System.Convert.ToString(_4byte, 2));
            string swappedbin = "";
            //Console.WriteLine(bin);
            while (bin.Length > 0)
            {
                if (bin.Length > 7)
                {
                    swappedbin += "1" + bin.Substring(bin.Length - 7);
                    bin = bin.Substring(0, bin.Length - 7);
                }
                else
                {
                    while (bin.Length < 8)
                        bin = "0" + bin;
                    swappedbin += bin;
                    bin = "";
                }
            }
            //Console.WriteLine(swappedbin);
            try
            {
                int ret = System.Convert.ToInt32(swappedbin, 2);
                return ret;
            }
            catch
            {
            }
            return _u30;
        }

        private void OnPropertyChanged(string PropertyName)
        {
           System.ComponentModel.PropertyChangedEventHandler temp = PropertyChanged;
            if (temp != null)
            {
                temp(this, new System.ComponentModel.PropertyChangedEventArgs(PropertyName));
            }
        }

    }
}
