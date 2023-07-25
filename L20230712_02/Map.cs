using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230712_02
{
    internal class Map
    {
        public Map() 
        {
            _xSize = 1;
            _ySize = 1;
        }

        ~Map() { }

        public int xSize
        {
            get
            {
                return _xSize;
            }
            set
            {
                if(value >= 1)
                {
                    _xSize = value;
                }
            }
        }
        public int ySize
        {
            get
            {
                return _ySize;
            }
            set
            {
                if(value >= 1)
                {
                    _ySize = value;
                }
            }
        }

        public int[] goalPos
        {
            get
            {
                return _goalPos;
            }
            set
            {
                if ((value[0] >= 0) && (value[1] >= 0))
                {
                    _goalPos = value;
                }
            }
        }

        private int _xSize = 1;
        private int _ySize = 1;
        private int[] _goalPos = new int[2];
    }
}
