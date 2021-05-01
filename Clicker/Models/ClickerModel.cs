using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clicker.Models
{
    class ClickerModel
    {
        private int _level;
        private long _value;
        private long _money;
        public int Level
        {
            get { return _level; }
            set { _level = value; }
        }
        public long Value
        {
            get { return _value; }
            set { _value = value; }
        }
        public long Money
        {
            get { return _money; }
            set { _money = value; }
        }
    }
}
