using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaise
{
    class Seat
    {
        private bool  _isFree;
        private int _numberOfLegs;
        private bool _hasABack;
        private bool _hasArmrests;

       public bool IsFree
        {
            get { return _isFree; }
            protected set { _isFree = value; }
        }
        public int NumberOfLegs
        {
            get { return _numberOfLegs; }
        }
        public bool HasABack
        {
            get { return _hasABack; }
        }
        public  bool HasArmrest
        {
            get { return _hasArmrests; }
        }
        public void AddPersonOnIt()
        {
          
            if(IsFree )
            {
                IsFree = true;
                if(IsFree)
            }
        }
        public void RemoveAPersonFromIt()
        {
            IsFree = false;
        }
    }
}
