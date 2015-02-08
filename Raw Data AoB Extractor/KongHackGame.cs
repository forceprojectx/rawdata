using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Raw_Data_AoB_Extractor
{
    class KongHackGame
    {
         public KongHackGame() { }
        public KongHackGame(int _id, string _name)
        {
            this.id = _id;
            this.name = _name;
           
        }

        int _id;
        string _name;

        override public string ToString()
        {
            return _name;
        }
     
    
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
